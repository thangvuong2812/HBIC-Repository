using AutoMapper;
using BusinessObject;
using BusinessObject.BOPersonalAccounts;
using DataAccess.ActionMethod;
using DataAccess.HBICModels;
using HBIC_Official.Code;
using HBIC_Official.MailServices;
using HBIC_Official.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RESTCountries.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HBIC_Official.Controllers
{
    public class UserController : Controller
    {


        //Du lieu mau nhom cac chuyen nganh
        static List<DetailSpecialization> TechGroup = new List<DetailSpecialization>()
           {
               new DetailSpecialization { ValueId = "bd", Name = "Bảo dưỡng công nghiệp", GroupName = "Khối kỹ thuật"},
               new DetailSpecialization { ValueId = "ck", Name = "Cơ khí", GroupName = "Khối kỹ thuật"},
               new DetailSpecialization { ValueId = "dc", Name = "Kỹ thuật địa chất", GroupName = "Khối kỹ thuật"},
               new DetailSpecialization { ValueId = "dt", Name = "Điện - điện tử", GroupName = "Khối kỹ thuật"},


           };
        static List<DetailSpecialization> EconomicGroup = new List<DetailSpecialization>()
        {
             new DetailSpecialization { ValueId = "qtkd", Name = "Quản trị kinh doanh", GroupName = "Khối luật & kinh tế"},
               new DetailSpecialization { ValueId = "kt", Name = "Kế toán", GroupName = "Khối luật & kinh tế"},
               new DetailSpecialization { ValueId = "tcnh", Name = "Tài chính ngân hàng", GroupName = "Khối luật & kinh tế"},
               new DetailSpecialization { ValueId = "httt", Name = "Hệ thống thông tin", GroupName = "Khối luật & kinh tế"},
        };
        private readonly HBICAction hBICAction;

        private readonly ILogger<UserController> _logger;
        private readonly IMailService _emailSender;
        private readonly IConfiguration _config;

        private static BOUserInfo _userInfo { get; set; }
        [BindProperty]
        public CoreUser UserInfo { get; set; }
        private readonly IMapper _mapper;
        public UserController(ILogger<UserController> logger, IMapper mapper, IMailService emalSender, HBICAction MyHBICAction)
        {
            _config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            _logger = logger;
            _emailSender = emalSender;
            _mapper = mapper;
            hBICAction = MyHBICAction;
        }

        public IActionResult Login(string returnUrl = null)
        {
            if(!string.IsNullOrEmpty(returnUrl))
            {
                ViewBag.ReturnUrl = returnUrl;
            }
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        private async Task<string> SendEmailCode(string email, string subject, string body)
        {
            string code = Guid.NewGuid().ToString();
        
            if (string.IsNullOrEmpty(code))
            {
                return string.Empty;
            }
            try
            {
                MailRequest mailRequest = new MailRequest
                {
                    ToEmail = email,
                    Subject = subject,
                    Body = body + code,
                };
                await _emailSender.SendEmailAsync(mailRequest);
                return code;
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return string.Empty;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Register(BORegister boRegister, string returnUrl = null)
        {
            if(ModelState.IsValid)
            {
                //BOConfirmEmail confirmEmail = new BOConfirmEmail { Email = boRegister.Email.Trim() };
                //return View("ConfirmEmail", confirmEmail);
                string passwordHash = Code.Encrypt.ToSHA256(boRegister.Password);
                bool isExistUser = hBICAction.CheckUserName(boRegister.UserName, boRegister.Email);
                if (!isExistUser)
                {
                    var user = hBICAction.SignUp(boRegister.UserName, boRegister.Email, passwordHash);
                    if (user != null)
                    {
                        _logger.LogInformation("Vừa tạo mới tài khoản thành công.");
                        
                        string code = await SendEmailCode(boRegister.Email, "Xác nhận địa chỉ email", "Hãy xác nhận địa chỉ email bằng cách điển mã này vào trang xác thực: ");
                        if (string.IsNullOrEmpty(code))
                        {
                            ModelState.AddModelError("", "Có lỗi trong quá trình xác thực");
                            return RedirectToAction("ConfirmEmail", new BOConfirmEmail { Email = boRegister.Email });
                        }
                        int expiredCodeSecond = 120;
                        DateTime codeTime = DateTime.Now.AddSeconds(expiredCodeSecond);
                        hBICAction.Insert_EmailCode(boRegister.Email, code, codeTime);
                       // var callbackUrl = Url.Page(
                       //"/User/ConfirmEmail",
                       //pageHandler: null,
                       //values: new { area = "Identity", userId = user.UserId, code = code, returnUrl = returnUrl },
                       //protocol: Request.Scheme);
                        
                        //await _emailSender.SendEmailAsync(boRegister.Email, "Xác nhận địa chỉ email",
                        //$"Hãy xác nhận địa chỉ email bằng cách <a href='{callbackUrl}'>Bấm vào đây</a>.");
                        //{ email = boRegister.Email, returnUrl = returnUrl }
                        return RedirectToAction("ConfirmEmail", new BOConfirmEmail { Email = boRegister.Email });
                        
                       
                        //return View("Login",new BOLogin { UserName = boRegister.UserName, Password = boRegister.Password, RememberMe = true } );
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Email hoặc tên tài khoản đã tồn tại");
                }
            }

            return View(boRegister);

        }
        
        public async Task<JsonResult> RefreshAutEmail(string email)
        {
           
            string code = await SendEmailCode(email, "Xác nhận địa chỉ email", "Hãy xác nhận địa chỉ email bằng cách điển mã này vào trang xác thực: ");
            if (string.IsNullOrEmpty(code))
            {

                return Json(new { success = false });
            }
            int expiredCodeSecond = 120;
            DateTime codeTime = DateTime.Now.AddSeconds(expiredCodeSecond);
            hBICAction.Insert_EmailCode(email, code, codeTime);
            return Json(new { success = !string.IsNullOrEmpty(code) });
        }

        public IActionResult ConfirmEmail(string email = null)
        {
            if(string.IsNullOrEmpty(email))
                return View(new BOConfirmEmail { Email = email });
            return View();
        }

        /// <summary>
        /// Action to click confirm button  
        /// </summary>
        /// <param name="confirmEmail"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> ConfirmEmail(BOConfirmEmail confirmEmail)
        {
            //Set auth code at here
            if(ModelState.IsValid)
            {
                var user = await hBICAction.Select_UserByEmail(confirmEmail.Email);
                if(user != null)
                {
                    bool isAuth = confirmEmail.AuthCode == user.EmailCode;
                    // Expired time: 1 minutes
                    var compareExpiredTime = DateTime.Compare(user.EmailCodeTime.GetValueOrDefault(), DateTime.Now);
                    if(isAuth == true && compareExpiredTime > 0)
                    {

                        return View("Login", new BOLogin { UserName = user.UserName, RememberMe = true });
                    }
                }
            }
            ModelState.AddModelError("", "Nhập sai mã xác thực hoặc mã hết hạn");
            return View(confirmEmail);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(BOLogin loginModel,string returnUrl)
        {
            if (ModelState.IsValid)
            {
                string passwordHass = Code.Encrypt.ToSHA256(loginModel.Password);
         
                var authUser = hBICAction.CheckLogin(loginModel.UserName, passwordHass);
                if (authUser != null)
                {

                    StoreAccountToCookie(authUser, loginModel.RememberMe);
                    return Redirect(returnUrl ?? "/");
                }
            }            
            ModelState.AddModelError("", "Invalid User!");
            return View("Login", loginModel); 
        }

        public async Task<IActionResult> Logout()
        {
            TempData["isLogin"] = false;
            await HttpContext.SignOutAsync(scheme: "PSecurityScheme2");
            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public async Task<IActionResult> DetailAccount()
        {
            int userId = int.Parse(((System.Security.Claims.ClaimsIdentity)User.Identity).Claims.ToList()[0].Value.ToString());
            var user = await hBICAction.Select_UserById(userId);
            //Khong nhan submit
            if(user != null)
            {
                if(user.GroupId == null)
                {
                    user.GroupId = 1; //Mac dinh nhom dau tien
                }
                if(user.SubjectId == null)
                    user.SubjectId = 1;
            }    
                    
           
            //Lan dau chay 

            var specializeGroupsTask = hBICAction.Select_AllSpecialityGroup();
            var selectSpecialitiesByGroupTask = new HBICAction().Select_SpecialitiesBySpeGroupId(user.SpecialityGroupId ?? 1);
            var listHBICCoopsTask = new HBICAction().Select_HbiccoopsBySubjectId(user.SubjectId.Value);
            var subjectsTask = new HBICAction().Select_SubjectsBySubjectGroupId((long)(user?.GroupId));
            var investmentTypes = new HBICAction().Select_AllInvestmentTypes();
            var investmentSpecsTask = new HBICAction().Select_AllInvestmentSpecialities();

            var selectedInvestmentTypesTask = new HBICAction().Select_InvestmentTypesByUserId(userId);
            var selectedInvestmentSpecsTask = new HBICAction().Select_InvestmentSpecsByUserId(userId);

            await Task.WhenAll(specializeGroupsTask, selectSpecialitiesByGroupTask, listHBICCoopsTask, subjectsTask, investmentTypes, investmentSpecsTask, selectedInvestmentTypesTask, selectedInvestmentSpecsTask);

            IEnumerable<SelectListItem> selectLists;
            List<SelectListItem> selectSpecialities;
            var selectedInvestmentTypes = investmentTypes.Result.Select(o => new SelectListItem { Value = o.Value, Text = o.Title, Selected = selectedInvestmentTypesTask.Result.Select(x => x.InvestmentTypeValue).Contains(o.Value) });
            var specializeGroups = specializeGroupsTask.Result;
            var selectSpecialitiesByGroup = selectSpecialitiesByGroupTask.Result;
            var listHBICCoops = listHBICCoopsTask.Result;
            var subjects = subjectsTask.Result;
            var investmentSpecs = investmentSpecsTask.Result.Select(o => new SelectListItem { Value = o.Value, Text = o.Title, Selected = selectedInvestmentSpecsTask.Result.Select(x => x.InvestmentSpecValue).Contains(o.Value) });
            var countries = GetCountries();
            selectLists = specializeGroups.Select(o => new SelectListItem { Value = o.SysId.ToString(), Text = o.GroupName });
            selectSpecialities = selectSpecialitiesByGroup.Select(o => new SelectListItem { Value = o.SpecialityId.ToString(), Text = o.Title }).ToList();

            var userSelectedList = hBICAction.Select_CoreFieldUserCoopByUserId(userId);

             
            ViewBag.Countries = countries.Select(o => new SelectListItem {  Text = o.DisplayName, Value = o.TwoLetterISOLanguageName }).ToList();
            ViewBag.Specialities = selectSpecialities;
            ViewBag.SpecialiyGroups = selectLists;
            ViewBag.Subjects = subjects;

            BOUserInfo boModel = _mapper.Map<CoreUser, BOUserInfo>(user);
            boModel.FieldHbicCoops = listHBICCoops.Select(x => new SelectListItem { Value = x.SysId.ToString(), Text = x.Title, Selected = CheckExistValueList(x.SysId, userSelectedList) }).ToList();
            boModel.InvestmentTypes = selectedInvestmentTypes.ToList();
            boModel.InvestmentSpecs = investmentSpecs.ToList();
            return View(boModel);
        }
   

        private bool CheckExistValueList(long patternValue, List<CoreFieldUserCoop> checkList)
        {
            foreach(var i in checkList)
            {
                if (patternValue == i.HbiccoopId)
                    return true;
            }
            return false;
        }
        public async Task<IActionResult> SelectGroup(int accountTypeId, int? subjectTypeId)
        {
            int userId = int.Parse(((System.Security.Claims.ClaimsIdentity)User.Identity).Claims.ToList()[0].Value.ToString());
            if(subjectTypeId == null)
            {
                subjectTypeId = accountTypeId == 1 ? 1 : 3;
            }
                hBICAction.Update_SubjectGroup(userId, subjectTypeId.Value, accountTypeId);
                return RedirectToAction("DetailAccount");
        }


        public async Task<IActionResult> Get_SpecialitiesBySpeGroupId(int specialityGroupId)
        {
            var specialities = await hBICAction.Select_SpecialitiesBySpeGroupId(specialityGroupId);
            //return RedirectToAction("DetailAccount", )
            return Json(new { success = specialities != null, data = specialities });
        }

       

        private List<CultureInfo> GetCountries()
        {
            var countries = CultureInfo.GetCultures(CultureTypes.SpecificCultures).Distinct().OrderBy(x => x.DisplayName).ToList();
            return countries;
        }

        public async Task<JsonResult> Select_SpecializeGroup(int specializeGroupId)
        {
            var specialities = await hBICAction.Select_SpecialitiesBySpeGroupId(specializeGroupId);
            return Json(new { success = specialities != null && specialities.Count > 0, data = specialities});
        }

        public async Task<IActionResult> PAResearcher(BOUserBase boAccountInfo)
        {
            return View("PA_Researcher");
        }

        //private string GetPartialView(int subjectTypeId)
        //{
        //    string partialViewPath = string.Empty;
        //    switch (subjectTypeId)
        //    {
        //        case 1:

        //    }
        //}


        private async void StoreAccountToCookie(CoreUser userAccount, bool isRemember = true)
        {
            //https://viblo.asia/p/su-dung-cookie-authentication-trong-aspnet-core-djeZ1VG8lWz
            // create claims
            List<Claim> claims = new List<Claim>
                    {
                        //new Claim(ClaimTypes.Name, "Cookie authentication"),                        
                        new Claim(ClaimTypes.NameIdentifier, userAccount.UserId.ToString()),
                        new Claim(ClaimTypes.Name, userAccount.UserName),
                        new Claim(ClaimTypes.Email, userAccount.Email),
                        new Claim(ClaimTypes.Role, userAccount.Role),
                        //new Claim(ClaimTypes.GivenName, userAccount.FirstName + " " + userAccount.LastName),
                        //new Claim(ClaimTypes.Thumbprint, string.IsNullOrEmpty(senUser.Avatar) && !senUser.Avatar.Contains(".") ? "" : Code.PMS_ParseAvatar.ParseAvatar(senUser.Avatar)),
                        
                    };

            // create identity
            ClaimsIdentity identity = new ClaimsIdentity(claims, "cookie");

            // create principal
            ClaimsPrincipal principal = new ClaimsPrincipal(identity);

            // sign-in
            await HttpContext.SignInAsync(
                    scheme: "PSecurityScheme2",
                    principal: principal,
                    properties: new AuthenticationProperties
                    {
                        IsPersistent = isRemember, // for 'remember me' feature
                                                   //ExpiresUtc = DateTime.UtcNow.AddDays(30)//Only need Persistent
                    });

        }

        [HttpPost]
        public async Task<IActionResult> SubmitInfo(BOUserInfo userViewModel)
        {
            int userId = int.Parse(((System.Security.Claims.ClaimsIdentity)User.Identity).Claims.ToList()[0].Value.ToString());
            var selectedList = userViewModel.FieldHbicCoops.Where(o => o.Selected == true).Select(o => int.Parse(o.Value)).ToList();
            var selectedInvestmentTypes = userViewModel.InvestmentTypes?.Where(o => o.Selected == true).Select(o => o.Value).ToArray();
            var selectedInvestmentSpecs = userViewModel.InvestmentSpecs?.Where(o => o.Selected == true).Select(o => o.Value).ToArray();
            if (selectedList != null)
            {
                hBICAction.Delete_CoreFieldUserCoopByUserId(userId);
                hBICAction.Insert_CoreFieldUserCoop(userId, selectedList);
            }    
            if (selectedInvestmentTypes != null)
            {
                hBICAction.Delete_InvestmentTypesByUserId(userId);
                await hBICAction.Insert_CoreFieldUserInvestmentType(userId, selectedInvestmentTypes);
            }
            if (selectedInvestmentSpecs != null)
            {
                hBICAction.Delete_InvestmentSpecByUserId(userId);
                await hBICAction.Insert_CoreFieldUserInvestmentSpec(userId, selectedInvestmentSpecs);
            }
            //var userId = context.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
            userViewModel.UserId = userId;
            var user = hBICAction.Update_UserInfo(userViewModel);
            ViewBag.SubjectTypeId = userViewModel.SubjectId;

            return RedirectToAction("DetailAccount");
        }

        public async Task<IActionResult> UploadFile(BOUserInfo userViewModel)
        {
            int userId = int.Parse(((System.Security.Claims.ClaimsIdentity)User.Identity).Claims.ToList()[0].Value.ToString());
            var porfolioTask = await InsertFile(userId, userViewModel.PorfolioFile, "portfolio");
            var firmProfileTask = await InsertFile(userId, userViewModel.FirmProfile, "firmprofile");
            var financialfileTask = await InsertFile(userId, userViewModel.FinancialStatementFile, "financialfile");
      
            return RedirectToAction("DetailAccount");
        }


        private async Task<string> InsertFile(int userId, IFormFile file, string fileType)
        {
            if (file != null)
            {
                var ftpConn = _config.GetSection("FTPConnection");
                string ftpUrl = ftpConn.GetSection("FtpUrl").Value;
                string ftpHttp = ftpConn.GetSection("FtpHttp").Value;
                var filePathObj = await new UpLoadFile().UploadSingle(file);

                bool isUpdate = false;
                if (filePathObj != null)
                {
                    string httpLink = filePathObj.FullPath.Replace(ftpUrl, ftpHttp);
                    switch (fileType.ToLower())
                    {
                        case "firmprofile":
                            isUpdate = hBICAction.Update_FirmFilePath(userId, httpLink);
                            break;
                        case "portfolio":
                            isUpdate =  hBICAction.Update_PorfolioFilePath(userId, httpLink);
                            break;
                        case "financialfile":
                            isUpdate =  hBICAction.Update_FinancialFilePath(userId, httpLink);
                            break;
                        case "avatar":
                            isUpdate = hBICAction.Update_AvatarPath(userId, httpLink);
                            break;
                    }

                    var insertedfile = hBICAction.Insert_File(new FieldFile { UserId = userId, FilePath = filePathObj.FilePath, CreatedDate = DateTime.Now, IsDelete = false, CreatedBy = userId.ToString(), FileType = fileType });
                    var isDeleted = await hBICAction.Delete_FilesByFileType(userId, fileType);

                    return httpLink;
                }
            }
            return string.Empty;
        }


        public async Task<IActionResult> ClearFile(string filePath, string fileType)
        {
            int userId = int.Parse(((System.Security.Claims.ClaimsIdentity)User.Identity).Claims.ToList()[0].Value.ToString());
            if (!string.IsNullOrEmpty(filePath))
            {
                bool isUpdate = false;

                if (!string.IsNullOrEmpty(fileType))
                {
                    await hBICAction.Delete_File(userId, filePath);
                    switch (fileType.ToLower())
                    {
                        case "firmprofile":
                            isUpdate = hBICAction.Update_FirmFilePath(userId, null);
                            break;
                        case "portfolio":
                            isUpdate = hBICAction.Update_PorfolioFilePath(userId, null);
                            break;
                        case "financialfile":
                            isUpdate = hBICAction.Update_FinancialFilePath(userId, null);
                            break;
                    }
                }
            }
            return RedirectToAction("DetailAccount");
        }
        
        public async Task<IActionResult> Get_HBICCoopsBySubjectId(int subjectId)
        {
            var result = await hBICAction.Select_HbiccoopsBySubjectId(subjectId);
            return Json(new { success = result != null, data = result });
        }

       
        
        public async Task<IActionResult> ForgotPassWord_EmailForm()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendResetPassCode(BOForgotPass_Email model)
        {
            if(ModelState.IsValid)
            {
                string code = await SendEmailCode(model.Email, "Cấp lại mật khẩu", "Điền mã này vào trang để được cấp lại mật khẩu: ");
         
                if (!string.IsNullOrEmpty(code))
                {
                    int expiredCodeSecond = 120;
                    DateTime codeTime = DateTime.Now.AddSeconds(expiredCodeSecond);
                    hBICAction.Insert_ResetPassCode(model.Email, code, codeTime);
                    BOConfirmEmail newModel = new BOConfirmEmail { Email = model.Email };
                    return View("ForgotPassword_ConfirmEmailForm", newModel);
                }

            }
            return View("ForgotPassword_EmailForm", model);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword_ResetForm(BOConfirmEmail model)
        {
            if (ModelState.IsValid)
            {
                var user = await hBICAction.Select_UserByEmail(model.Email);
                if (user != null)
                {
                    bool isAuth = model.AuthCode == user.ResetPassCode;
                    // Expired time: 1 minutes
                    var compareExpiredTime = DateTime.Compare(user.ResetPassCodeTime.GetValueOrDefault(), DateTime.Now);
                    if (isAuth == true && compareExpiredTime > 0)
                    {
                        return View(new BOForgotPass_Reset { UserName = user.UserName, Email = user.Email });
                    }
                }
            }
            ModelState.AddModelError("", "Nhập sai mã xác thực hoặc mã hết hạn");
            return View("ForgotPassword_ConfirmEmailForm", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPass(BOForgotPass_Reset resetModel)
        {
            if(ModelState.IsValid)
            {
                string passwordHass = Code.Encrypt.ToSHA256(resetModel.Password);

                var isReset = hBICAction.Update_PasswordByEmail(resetModel.Email, passwordHass);
                if(isReset)
                {
                    return View("Login", new BOLogin { UserName = resetModel.UserName });
                }
            }
            return View("ForgotPassword_ResetForm", resetModel);
        }
        public async Task<JsonResult> RefreshResetAutEmail(string email)
        {

            string code = await SendEmailCode(email, "Cấp lại mật khẩu", "Điền mã này vào trang để được cấp lại mật khẩu: ");

            if (string.IsNullOrEmpty(code))
            {

                return Json(new { success = false });
            }
            int expiredCodeSecond = 120;
            DateTime codeTime = DateTime.Now.AddSeconds(expiredCodeSecond);
            hBICAction.Insert_ResetPassCode(email, code, codeTime);
            return Json(new { success = !string.IsNullOrEmpty(code) });
        }

        [HttpGet]
        public async Task<IActionResult> SettingsAccount()
        {
            
            int userId = int.Parse(((System.Security.Claims.ClaimsIdentity)User.Identity).Claims.ToList()[0].Value.ToString());
            string avatarPath = hBICAction.Select_AvatarPathByUserId(userId);
            BOSettingsAccount model = new BOSettingsAccount
            {
                AvatarPath = avatarPath
            };
            ViewBag.Message = TempData["Message"] as string;
            //IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeAvatar(BOSettingsAccount model)
        {
            if(model != null && model.AvatarImage != null)
            {
                int userId = int.Parse(((System.Security.Claims.ClaimsIdentity)User.Identity).Claims.ToList()[0].Value.ToString());
                string avatarLink = await InsertFile(userId, model.AvatarImage, "avatar");
                if(!string.IsNullOrEmpty(avatarLink))
                {
                    var isDeleted = await hBICAction.Delete_FilesByFileType(userId, "avatar");
                    if (isDeleted)
                        TempData["Message"] = "Change saved successfully!";
                    else
                        TempData["Message"] = "Error!";
                }

            }
            return RedirectToAction("SettingsAccount");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeAvatarFile(IFormFile file)
        {
            if (file != null)
            {
                int userId = int.Parse(((System.Security.Claims.ClaimsIdentity)User.Identity).Claims.ToList()[0].Value.ToString());
                string avatarLink = await InsertFile(userId, file, "avatar");

            }
            return RedirectToAction("SettingsAccount");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(BOSettingsAccount model)
        {
            
            int userId = int.Parse(((System.Security.Claims.ClaimsIdentity)User.Identity).Claims.ToList()[0].Value.ToString());
            string avatarPath = hBICAction.Select_AvatarPathByUserId(userId);
            if (ModelState.IsValid)
            {
                var user = await hBICAction.Select_UserById(userId);
                if(user == null)
                {
                  
                    ModelState.AddModelError("", "Invalid user!");
                    return View("SettingsAccount", model);
                }
                
                string currentPasswordHash = Code.Encrypt.ToSHA256(model.Password);
                if (currentPasswordHash != user.PasswordHash)
                {
                    ModelState.Clear();
                    ModelState.AddModelError("", "Sai mật khẩu");


                }
                else
                {
                    var isUpdatePass = false;
                    string newPasswordHash = Code.Encrypt.ToSHA256(model.NewPassword);
                    isUpdatePass = hBICAction.Update_PasswordById(userId, newPasswordHash);
                    if(isUpdatePass)
                    {
                        ModelState.Clear();
                        ModelState.AddModelError("", "Đổi mật khẩu thành công!");

                    }
                }
            }
            else
            {

                ModelState.Clear();
                ModelState.AddModelError("", "Confirm password doesn't match");
            }
            model.AvatarPath = avatarPath;
            model.Password = null;
            model.NewPassword = null;
            model.ConfirmPassword = null;

            return View("SettingsAccount", model);
        }

        [HttpGet]
        public async Task<JsonResult> GetAvatar(int userId)
        {
            var user = await hBICAction.Select_UserById(userId);
            return Json(new { success = user?.AvatarPath != null, data = user?.AvatarPath });
        }
     
        public async Task<IActionResult> ShowDetailInfo(int id)
        {
            string strUserId = ((System.Security.Claims.ClaimsIdentity)User.Identity).Claims.Count() > 0 ? ((System.Security.Claims.ClaimsIdentity)User.Identity).Claims.ToList()[0]?.Value : string.Empty;
            ViewBag.IsLogin = !string.IsNullOrEmpty(strUserId);
            ViewBag.UserId = id;
            var user = await hBICAction.Select_UserById(id);
            
            if (user != null)
            {
                var boUser = _mapper.Map<CoreUser, BOShowDetailInfo>(user);
                var fieldInvestmentTypes = await hBICAction.Select_InvestmentTypesByUserId(id);
                var selectedInvestmentSpecs = await hBICAction.Select_InvestmentSpecsByUserId(id);
                //Chua dang nhap
                if (string.IsNullOrEmpty(strUserId))
                    boUser.IsLiked = false;
                else
                {
                    int userId = int.Parse(((System.Security.Claims.ClaimsIdentity)User.Identity).Claims.ToList()[0]?.Value);
                    var isLiked = hBICAction.CheckExist_LikeList(userId, id);
                    boUser.IsLiked = isLiked;
                }
                //if (fieldInvestmentTypes != null && fieldInvestmentTypes.Count > 0)
                //{

                //    fieldInvestmentTypes.ForEach(o => boUser.StrInvestmentTypes += (o.InvestmentTypeValueNavigation.Title + ", "));
                //}
                //if (selectedInvestmentSpecs != null && selectedInvestmentSpecs.Count > 0)
                //{

                //    selectedInvestmentSpecs.ForEach(o => boUser.StrInvestmentSpecs += (o.InvestmentSpecValueNavigation.Title + ", "));
                //}

                //await Task.Delay(500);
                var task1 = Task.Run(() =>
                {
                    if (fieldInvestmentTypes != null && fieldInvestmentTypes.Count > 0)
                    {

                        fieldInvestmentTypes.ForEach(o => boUser.StrInvestmentTypes += (o.InvestmentTypeValueNavigation.Title + ", "));
                    }

                });

                var task2 = Task.Run(() =>
                {
                    if (selectedInvestmentSpecs != null && selectedInvestmentSpecs.Count > 0)
                    {

                        selectedInvestmentSpecs.ForEach(o => boUser.StrInvestmentSpecs += (o.InvestmentSpecValueNavigation.Title + ", "));
                    }
                });

                await Task.WhenAll(task1, task2).ConfigureAwait(false);
                return View(boUser);
            }
            return View("Error", new ErrorViewModel { RequestId = id.ToString() });
        }

        [HttpPost]
        public IActionResult HideFirmProfile(bool isChecked)
        {
            
            int userId = int.Parse(((System.Security.Claims.ClaimsIdentity)User.Identity).Claims?.ToList()[0].Value.ToString());

            bool isUpdateCheck = hBICAction.UpdateHideField(userId, isChecked);
        
            return Json(new { success = isUpdateCheck });
    
        }


        [HttpGet]
        public async Task<JsonResult> GetUserInfoById(string userId)
        {
            
            if (userId != null && !string.IsNullOrEmpty(userId))
            {

                List<BOMetaPropertyInfo> propertyInfosList = await GetPropertiesObjAsync(long.Parse(userId));
                //.Select(x => x.GetCustomAttribute<DisplayAttribute>());

                var settings = new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    Error = (sender, args) =>
                    {
                        args.ErrorContext.Handled = true;
                    },
                };

                return Json(new { success = propertyInfosList.Count > 0, data = propertyInfosList }, settings);
            }
            return Json(new { success = false });
        }

        [HttpPost]
        public async Task<JsonResult> AddLikeUsers(int userId)
        {
            int myUserId = int.Parse(((System.Security.Claims.ClaimsIdentity)User.Identity).Claims?.ToList()[0].Value.ToString());
            try
            {
                bool isSuccess = await hBICAction.AddLikeUser(myUserId, userId);
                return Json(new { success = isSuccess });
            }
            catch(Exception ex)
            {
                return Json(new { success = false });
            }
            
        }

        [HttpDelete]
        public async Task<JsonResult> DeleteLikeUsers(int userId)
        {
            int myUserId = int.Parse(((System.Security.Claims.ClaimsIdentity)User.Identity).Claims?.ToList()[0].Value.ToString());
            try
            {
                bool isSuccess = await hBICAction.DeleteLikeUser(myUserId, userId);
                return Json(new { success = isSuccess });
            }
            catch (Exception ex)
            {
                return Json(new { success = false });
            }

        }

        

        private async Task<List<BOMetaPropertyInfo>> GetPropertiesObjAsync(long userId)
        {
            CoreUser coreUser = null;
            coreUser = await hBICAction.Select_UserById(userId);
            var fieldInvestmentTypes = await hBICAction.Select_InvestmentTypesByUserId(userId);
            var userInfoVM = _mapper.Map<CoreUser, BOShowDetailInfo>(coreUser);
            if (fieldInvestmentTypes != null && fieldInvestmentTypes.Count > 0)
            {

                fieldInvestmentTypes.ForEach(o => userInfoVM.StrInvestmentTypes += (o.InvestmentTypeValueNavigation.Title + ", "));
            }
            var displayName = typeof(BOShowDetailInfo)
            .GetProperties();
            List<BOMetaPropertyInfo> propertyInfosList = new List<BOMetaPropertyInfo>();
            var propertyInfos = userInfoVM.GetType().GetProperties();
            foreach (PropertyInfo p in propertyInfos)
            {
                string displayNameProp = string.Empty;
                if (p.CustomAttributes.Count() > 0)
                {
                    displayNameProp = p.GetCustomAttributes(typeof(DisplayAttribute), false).Cast<DisplayAttribute>().Single().Name;
                }
                var boProp = new BOMetaPropertyInfo
                {
                    DisplayName = displayNameProp,
                    PropertyName = p.Name,
                    PropertyValue = p.GetValue(userInfoVM)?.ToString() ?? string.Empty
                };
                propertyInfosList.Add(boProp);
            }
            return propertyInfosList;
        }
    }
}
