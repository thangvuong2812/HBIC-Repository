using AutoMapper;
using BusinessObject;
using BusinessObject.SearchViewModels;
using DataAccess.ActionMethod;
using DataAccess.HBICModels;
using HBIC_Official.Code;
using HBIC_Official.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace HBIC_Official.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly IMapper _mapper;
        readonly ILogger<AdminController> _logger;
        private HBICAction hBICAction;
        static BOAdmin_Approved  admin_ApprovedViewModel = new BOAdmin_Approved();
        public AdminController(ILogger<AdminController> logger, IMapper mapper)
        {
            _mapper = mapper;
            _logger = logger;
  
            hBICAction = new HBICAction();
        }
        
        public async Task<IActionResult> Index()
        {

            // Chua gui: 1; Chua duoc duyet: 2; Da duyet: 3; Tu choi: 4   
            var taskCountUnsubmit = hBICAction.Count_UserByAuthorizedStatus((int)Code.HBIC_Const.AuthorizedStatus.Unsubmit);
            var taskCountUnApproved = hBICAction.Count_UserByAuthorizedStatus((int)Code.HBIC_Const.AuthorizedStatus.UnApproved);
            var taskCountApproved = hBICAction.Count_UserByAuthorizedStatus((int)Code.HBIC_Const.AuthorizedStatus.Approved);
            var taskCountDeny = hBICAction.Count_UserByAuthorizedStatus((int)Code.HBIC_Const.AuthorizedStatus.Deny);
            await Task.WhenAll(taskCountUnsubmit, taskCountUnApproved, taskCountApproved, taskCountDeny);
            List<BOAccountNumber> accountNumbers = new List<BOAccountNumber> {
                new BOAccountNumber { Label = "Chưa gửi duyệt", HexColor = "#858796", ColorName = "secondary", HoverColor = "#777988", AccountNumber = taskCountUnsubmit.Result },
                
                new BOAccountNumber{ Label = "Đã duyệt", HexColor = "#1cc88a",ColorName = "success", HoverColor= "#169868", AccountNumber = taskCountApproved.Result },
                new BOAccountNumber{ Label= "Chưa duyệt", HexColor= "#f6c23e",ColorName = "warning", HoverColor= "#c38e09", AccountNumber = taskCountUnApproved.Result },
                new BOAccountNumber{ Label= "Từ chối", HexColor= "#e74a3b",ColorName = "danger", HoverColor= "#b62416", AccountNumber = taskCountDeny.Result },
            };
            ViewBag.AccountNumbers = accountNumbers;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Get_RegisterAccountMonthly(int year)
        {
            List<int> data = new List<int>();
            for(int i = 1; i <= 12; i++)
            {

                var accounts = await hBICAction.Count_UserCreatedMonthly(i,year);
                data.Add(accounts);
            }
          
            
            //int[] data = { 0, 10000, 5000, 15000, 10000, 20000, 5000, 25000, 10000, 30000, };
            return Json(new { success = data?.Count > 0, accounMonthlytList = data });
        }

        [HttpGet]
        public async Task<JsonResult> Get_AccountsPercent()
        {
            //const pieChartDatas = [
            //    { label: "Chưa gửi duyệt", color: "#858796", hoverColor: "#777988", accountsPer: 25 },
            //    { label= "Đã duyệt", color= "#1cc88a", hoverColor= "#169868", accountsPer= 50 },
            //    { label= "Chưa duyệt", color= "#f6c23e", hoverColor= "#c38e09", accountsPer= 12.5 },
            //    { label= "Từ chối", color= "#e74a3b", hoverColor= "#b62416", accountsPer= 12.5 },
            //]

            List<object> pieChartDatas = new List<object> { 
                new { label = "Chưa gửi duyệt", color = "#858796", colorName = "secondary", hoverColor = "#777988", accountsPer = 200 },
                new { label = "Đã duyệt", color = "#1cc88a",colorName = "success", hoverColor= "#169868", accountsPer= 2000 },
                new { label= "Chưa duyệt", color= "#f6c23e",colorName = "warning", hoverColor= "#c38e09", accountsPer= 500 },
                new { label= "Từ chối", color= "#e74a3b",colorName = "danger", hoverColor= "#b62416", accountsPer= 100 },
            };

            return Json(new { success = true, pieChartDatas = pieChartDatas });
        }

       
        public async Task<IActionResult> MA_RegisterAccounts()
        {
            List<CoreUser> RegisterAccounts = new List<CoreUser>();
            RegisterAccounts = await hBICAction.Select_UsersByAuthStatus();
            List<BOUserInfo> userInfoViewModels = _mapper.Map<List<CoreUser>, List<BOUserInfo>>(RegisterAccounts);
            BOAdmin_Registers model = new BOAdmin_Registers { RegisterUsers = userInfoViewModels };
            return View(model);
        }

        
        public async Task<IActionResult> MA_ApprovedAccounts(BOSearch searchModel = null)
        {
            //https://stackoverflow.com/questions/54843810/ef-core-a-second-operation-started-on-this-context-before-a-previous-operation
            var hbicAction2 = new HBICAction();
            var hbicAction3 = new HBICAction();
            var hbicAction4 = new HBICAction();
            var hbicAction5 = new HBICAction();
            var specialities = hBICAction.Select_AllSpecialities();
            var specialityGroups = hbicAction2.Select_AllSpecialityGroup();
            var subjectGroups = hbicAction3.Select_AllSubjectGroups();
            var titles = hbicAction4.Select_AllTitles();
            var subjects = hbicAction5.Select_AllSubjects();
            await Task.WhenAll(specialities, specialityGroups, subjectGroups, titles, subjects);
            admin_ApprovedViewModel.SearchAccount.Specialities = specialities.Result.Select(o => new SelectListItem { Value = o.SpecialityId.ToString(), Text = o.Title }).ToList();

            admin_ApprovedViewModel.SearchAccount.SpecialityGroups = specialityGroups.Result.Select(o => new SelectListItem { Value = o.SysId.ToString(), Text = o.GroupName }).ToList();
            admin_ApprovedViewModel.SearchAccount.SubjectGroups = subjectGroups.Result.Select(o => new SelectListItem { Value = o.GroupId.ToString(), Text = o.GroupTitle }).ToList();
            admin_ApprovedViewModel.SearchAccount.Titles = titles.Result.Select(o => new SelectListItem { Value = o.TitleCode.ToString(), Text = o.TitleName }).ToList();
            admin_ApprovedViewModel.SearchAccount.Subjects = subjects.Result.Select(o => new SelectListItem { Value = o.SysId.ToString(), Text = o.Title }).ToList();
            // Du lieu mau
            List<CoreUser> approvedAccounts = new List<CoreUser>();
            if (searchModel == null || IsAllNullOrEmpty(searchModel))
            {
                approvedAccounts = await hBICAction.Select_UsersByAuthStatus((int)HBIC_Const.AuthorizedStatus.Approved);
            }
            else // Search
            {
                approvedAccounts = await hBICAction.Select_UsersByFilterSearch(searchModel);
            }
            List<BOUserInfo> userInfoViewModels = _mapper.Map<List<CoreUser>, List<BOUserInfo>>(approvedAccounts);
            admin_ApprovedViewModel.ApprovedUsers = userInfoViewModels;
            

            return View(admin_ApprovedViewModel);
        }

        public async Task<IActionResult> DenyUsers(string userIds, string returnUrl)
        {
            if (userIds != null)
            {
                var userIdsArr = userIds.Split(",");
                long[] parsedUserIds = Array.ConvertAll(userIdsArr, long.Parse);
                await hBICAction.Update_UsersAuthStatus(parsedUserIds, (short)HBIC_Const.AuthorizedStatus.Deny);
            }
            return Redirect(returnUrl);
        }

        public async Task<IActionResult> ApproveUsers(string userIds, string returnUrl)
        {
            if (userIds != null)
            {
                var userIdsArr = userIds.Split(",");
                long[] parsedUserIds = Array.ConvertAll(userIdsArr, long.Parse);
                await hBICAction.Update_UsersAuthStatus(parsedUserIds, (short)HBIC_Const.AuthorizedStatus.Approved, DateTime.Now);
            }
            return Redirect(returnUrl);
        }

        public async Task<IActionResult> UnApproveUsers(string userIds, string returnUrl)
        {
            if (userIds != null)
            {
                var userIdsArr = userIds.Split(",");
                long[] parsedUserIds = Array.ConvertAll(userIdsArr, long.Parse);
                await hBICAction.Update_UsersAuthStatus(parsedUserIds, (short)HBIC_Const.AuthorizedStatus.UnApproved);
            }
            return Redirect(returnUrl);
        }

        public async Task<IActionResult> MA_UnApprovedAccounts()
        {
            List<CoreUser> unApprovedAccounts = new List<CoreUser>();
            unApprovedAccounts = await hBICAction.Select_UsersByAuthStatus((int)HBIC_Const.AuthorizedStatus.UnApproved);
            List<BOUserInfo> userInfoViewModels = _mapper.Map<List<CoreUser>, List<BOUserInfo>>(unApprovedAccounts);
        
            BOAdmin_UnApproved model = new BOAdmin_UnApproved { UnApproveUsers = userInfoViewModels };
            
            return View(model);
        }

        public async Task<IActionResult> MA_DenyAccounts()
        {
            List<CoreUser> denyAccounts = new List<CoreUser>();
            denyAccounts = await hBICAction.Select_UsersByAuthStatus((int)HBIC_Const.AuthorizedStatus.Deny);
            List<BOUserInfo> userInfoViewModels = _mapper.Map<List<CoreUser>, List<BOUserInfo>>(denyAccounts);
            BOAdmin_Deny model = new BOAdmin_Deny { DenyUsers = userInfoViewModels };
            return View(model);
        }
 
        public async Task<IActionResult> MA_UnSubmitApprovementAccounts()
        {
            List<CoreUser> unsubmitAccounts = new List<CoreUser>();
            unsubmitAccounts = await hBICAction.Select_UsersByAuthStatus((int)HBIC_Const.AuthorizedStatus.Unsubmit);
            List<BOUserInfo> userInfoViewModels = _mapper.Map<List<CoreUser>, List<BOUserInfo>>(unsubmitAccounts);
            BOAdmin_UnSubmit model = new BOAdmin_UnSubmit { UnsubmitUser = userInfoViewModels };
            return View(model);
        }

        public async Task<IActionResult> PA_MyAccount()
        {
            return View();
        }
        private bool IsAllNullOrEmpty(object myObject)
        {
            foreach (PropertyInfo pi in myObject.GetType().GetProperties())
            {
                if (pi.PropertyType == typeof(string))
                {
                    string value = pi.GetValue(myObject) as string;
                    if (string.IsNullOrEmpty(value) == false)
                    {
                        return false;
                    }
                }

                if(pi.PropertyType == typeof(int?))
                {
                    int? value = pi.GetValue(myObject) as int?;
                    if (value != null && value != -1)
                        return false;
                }
                if (pi.PropertyType == typeof(double?))
                {
                    double? value = pi.GetValue(myObject) as double?;
                    if (value != null && value != -1)
                        return false;
                }
            }
            return true;
        }
       
        [HttpPost]
        public async Task<IActionResult> SearchAccounts(BOSearch viewModel)
        {
            admin_ApprovedViewModel.SearchAccount = viewModel;
           
            return RedirectToAction("MA_ApprovedAccounts" ,  viewModel );
        }
        public async Task<IActionResult> Reset()
        {
            admin_ApprovedViewModel.SearchAccount = new BOSearch();
            return RedirectToAction("MA_ApprovedAccounts");
        }
        [HttpGet]
        public async Task<IActionResult> GetSubjectsByGroupId(int groupId)
        {
            var subjects = await hBICAction.Select_SubjectsBySubjectGroupId(groupId);
            return Json(new { success = subjects != null, data = subjects });
        }
    }
}
