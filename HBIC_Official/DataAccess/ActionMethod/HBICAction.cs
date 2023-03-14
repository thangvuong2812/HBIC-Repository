using BusinessObject;
using BusinessObject.SearchViewModels;
using DataAccess.HBICModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.EntityFramework.Plus;

namespace DataAccess.ActionMethod
{
    public class HBICAction
    {
        private HBIC_DBContext context = null;

        public HBICAction()
        {
            context = new HBIC_DBContext();
        }


        public CoreUser CheckLogin(string username, string passwordHash)
        {
            var result = context.CoreUsers.FirstOrDefault(o => o.UserName == username && o.PasswordHash == passwordHash);
            return result;
        }

        public CoreUser SignUp(string userName, string email, string passwordHash, string role = "user")
        {
            var newUSer = new CoreUser
            {
                UserName = userName,
                Email = email,
                PasswordHash = passwordHash,
                Role = role,
                AuthorizedStatus = 1,
                CreatedDate = DateTime.Now
            };
            var result = context.CoreUsers.Add(newUSer);
            context.SaveChanges();
            return result.Entity;
        }

        public bool CheckUserName(string userName, string email)
        {
            var result = context.CoreUsers.FirstOrDefault(o => o.UserName.ToLower().Trim() == userName.ToLower().Trim() || o.Email == email.Trim());
            return result != null;
        }

        public string Insert_EmailCode(string email, string code, DateTime generateCodeTime)
        {
            var user = context.CoreUsers.FirstOrDefault(o => o.Email == email);
            if (user != null)
            {
                user.EmailCode = code;
                user.EmailCodeTime = generateCodeTime;
                context.SaveChanges();
                return code;
            }
            else
                return string.Empty;
        }

        public string Insert_ResetPassCode(string email, string code, DateTime generateCodeTime)
        {
            var user = context.CoreUsers.FirstOrDefault(o => o.Email == email);
            if (user != null)
            {
                user.ResetPassCode = code;
                user.ResetPassCodeTime = generateCodeTime;
                context.SaveChanges();
                return code;
            }
            return string.Empty;
        }

        public bool UpdateHideField(int userId, bool isChecked)
        {
            var user = context.CoreUsers.FirstOrDefault(o => o.UserId == userId);
            if(user != null)
            {
                user.IsHideFirmProfile = isChecked;
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public async Task<CoreUser> Select_UserById(long id)
        {
            var result = await context.CoreUsers.Include(o => o.TitleNavigation).Include(e => e.Subject).Include(o => o.Group).Include(o => o.Speciality).ThenInclude(o => o.SpecialityGroup).FirstOrDefaultAsync(o => o.UserId == id);
            return result;

        }

        public string Select_AvatarPathByUserId(long userId)
        {
            var result = context.CoreUsers.FirstOrDefault(o => o.UserId == userId).AvatarPath;
            return result;
        }

        public bool Update_AvatarPath(long userId, string avatarPath)
        {
            var user =  context.CoreUsers.FirstOrDefault(o => o.UserId == userId);
            if(user != null)
            {
                user.AvatarPath = avatarPath;
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public async Task<List<CoreUser>> Select_AllUsers()
        {
            var result = await context.CoreUsers.ToListAsync();
            return result;
        }

        public async Task<CoreUser> Select_UserByEmail(string email)
        {
            var result = await context.CoreUsers.FirstOrDefaultAsync(o => o.Email == email.Trim());
            return result;
        }

        public async Task<int> Count_UserByAuthorizedStatus(int authStatus)
        {
            int result = 0;
            string parameterStatement = "dbo.Count_CoreUser_AuthorizedStatus";
            using (SqlConnection conn = new SqlConnection(context.Database.GetConnectionString()))
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = parameterStatement;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@AuthorizedStatus", SqlDbType.Int).Value = authStatus;
                if (conn.State == ConnectionState.Closed)
                    await conn.OpenAsync();
                result = (int)cmd.ExecuteScalar();
                await conn.CloseAsync();
            }
            return result;
        }

        public async Task<int> Count_UserCreatedMonthly(int month, int year)
        {
            int result = 0;
            string parameterStatement = "[dbo].[Count_CoreUser_CreatedMonthly]";
            using (SqlConnection conn = new SqlConnection(context.Database.GetConnectionString()))
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = parameterStatement;
                cmd.CommandType = CommandType.StoredProcedure;
               
                cmd.Parameters.Add("@Month", SqlDbType.Int).Value = month;
                cmd.Parameters.Add("@Year", SqlDbType.Int).Value = year;
                var returnParameter = cmd.Parameters.Add("@return_value", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                if (conn.State == ConnectionState.Closed)
                    await conn.OpenAsync();




                cmd.ExecuteNonQuery();
                result = (int)returnParameter.Value;
                await conn.CloseAsync();
            }
            return result;
        }
        public CoreUser Update_SubjectGroup(int userId, int subjectId, int groupId)
        {
            var user = context.CoreUsers.FirstOrDefault(o => o.UserId == userId);
            if (user != null)
            {
                string groupTitle = context.CoreSubjectGroups.FirstOrDefault(o => o.GroupId == groupId).GroupTitle;
                string subjectTitle = context.CoreSubjects.FirstOrDefault(o => o.SysId == subjectId).Title;
                user.GroupTitle = groupTitle;
                user.SubjectTitle = subjectTitle;
                user.GroupId = groupId;
                user.SubjectId = subjectId;
                context.SaveChanges();
            }
            return user;
        }
        //Change AuthStatus = 2
        public CoreUser Update_UserInfo(BOUserInfo newUserInfo)
        {
            var user = context.CoreUsers.FirstOrDefault(o => o.UserId == newUserInfo.UserId);
            if (user != null)
            {
                user.FirstName = newUserInfo.FirstName;
                user.LastName = newUserInfo.LastName;
                user.Address = newUserInfo.Address;
                user.City = newUserInfo.City;
                user.Country = newUserInfo.Country;
                user.District = newUserInfo.District;
                user.Title = newUserInfo.Title;
                user.Telephone = newUserInfo.Telephone;
                user.BirthDay = newUserInfo.BirthDay;
                user.AuthorizedStatus = 2;
                user.Sex = newUserInfo.Sex;
                user.Description = newUserInfo.Description;
                user.SubjectId = newUserInfo.SubjectId;
                user.FullName = newUserInfo.FullName;
                user.SpecialityId = newUserInfo.SpecialityId;
                user.Certificate = newUserInfo.Certificate;
                user.ExpectedWork = newUserInfo.ExpectedWork;
                user.AddressSchoolWork = newUserInfo.AddressSchoolWork;
                user.Department = newUserInfo.Department;
                user.ExpectedSalary = newUserInfo.ExpectedSalary;
                user.ExtraSkill = newUserInfo.ExtraSkill;
                user.Career = newUserInfo.Career;
                user.SchoolYear = newUserInfo.SchoolYear;
                user.Achievement = newUserInfo.Achievement;
                user.GroupCompanyName = newUserInfo.GroupCompanyName;
                user.WebsiteAddress = newUserInfo.WebsiteAddress;
                user.EstablishYear = newUserInfo.EstablishYear;
                user.TaxCode = newUserInfo.TaxCode;
                user.TaxCodeTime = newUserInfo.TaxCodeTime;
                user.AttendeeNumber = newUserInfo.AttendeeNumber;
                user.IsHired = newUserInfo.IsHired;
                user.ProjectsCompanyCoop = newUserInfo.ProjectsCompanyCoop;
                user.IndustrialArea = newUserInfo.IndustrialArea;
                user.Zipcode = newUserInfo.Zipcode;
                user.Proceeds = newUserInfo.Proceeds;
                user.Quantity = newUserInfo.Quantity;
                user.MobilizedCapital = newUserInfo.MobilizedCapital;
                user.IsProceeds = newUserInfo.IsProceeds;
                user.DevelopmentStage = newUserInfo.DevelopmentStage;
                user.FirstProductTime = newUserInfo.FirstProductTime;
                user.AuthorizedCapital = newUserInfo.AuthorizedCapital;
                user.IsHardLookPartner = newUserInfo.IsHardLookPartner;
                user.IsNeedAdvisory = newUserInfo.IsNeedAdvisory;
                user.InvestmentFundId = newUserInfo.InvestmentFundId;
                user.AdministrativeCouncil = newUserInfo.AdministrativeCouncil;
                user.SubCompanyNumber = newUserInfo.SubCompanyNumber;
                user.SpecialityGroupId = newUserInfo.SpecialityGroupId;
                user.Machines = newUserInfo.Machines;
                user.Laboratories = newUserInfo.Laboratories;
                user.IsHideAuthorizedCapital = newUserInfo.IsHideAuthorizedCapital;
                user.IsHideEmail = newUserInfo.IsHideEmail;
                user.IsHideFullName = newUserInfo.IsHideFullName;
                user.IsHideLabs = newUserInfo.IsHideLabs;
                user.IsHideMobilizedCapital = newUserInfo.IsHideMobilizedCapital;
                user.IsHidePhoneNum = newUserInfo.IsHidePhoneNum;
                user.IsHideProceeds = newUserInfo.IsHideProceeds;
                user.IsHideMachines = newUserInfo.IsHideMachines;
                user.IsNeedHired = newUserInfo.IsNeedHired;
                user.LastSubmittedDate = DateTime.Now;
                context.SaveChanges();
                return user;
            }
            return null;
        }

        public async Task<List<CoreUser>> Select_UsersTop8ByMonth(int month, int year)
        {
            var result = await context.CoreUsers.Include(o => o.Speciality).Where(o => o.CreatedDate.Value.Month == month && o.CreatedDate.Value.Year == year && o.AuthorizedStatus == 3).OrderByDescending(o => o.CreatedDate).Take(8).ToListAsync();
            return result;
        }

        //Lấy dữ liệu theo đối tượng và tháng 
        public async Task<List<CoreUser>> Select_UsersByMonthAndSubjectId(int month, int year, int subjectId)
        {
            var result = await context.CoreUsers.Where(o => o.CreatedDate.Value.Month == month && o.CreatedDate.Value.Year == year && o.SubjectId == subjectId && o.AuthorizedStatus == 3).ToListAsync();
            return result;
        }

        public async Task<List<CoreUser>> Select_UpdatedUsersTop14()
        {
            var result = await context.CoreUsers.Where(o => o.LastSubmittedDate != null && o.AuthorizedStatus == 3).OrderByDescending(o => o.LastSubmittedDate).ToListAsync();
            return result;
        }

        public async Task<List<FieldSpecialityGroup>> Select_AllSpecialityGroup()
        {
            using var _context = new HBIC_DBContext();

            var result = await context.FieldSpecialityGroups.ToListAsync();
            return result;
        }

        public async Task<List<FieldSpeciality>> Select_SpecialitiesBySpeGroupId(long speGroupId)
        {
            var result = await context.FieldSpecialities.Where(o => o.SpecialityGroupId == speGroupId).ToListAsync();
            return result;
        }

        public async Task<bool> Update_SpecialityGroup(int userId, int specialityGroupId)
        {
            var user = await context.CoreUsers.FirstOrDefaultAsync(o => o.UserId == userId);
            if (user != null)
            {
                user.SpecialityGroupId = specialityGroupId;
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public async Task<List<FieldHbiccoop>> Select_HbiccoopsBySubjectId(long subjecId)
        {
            var result = await context.FieldHbiccoops.FromSqlInterpolated($"execute dbo.Get_FieldHBICCoopsBySubjectId {subjecId}").ToListAsync();
            return result;
        }

        public void Insert_CoreFieldUserCoop(int userId, List<int> hbicCoopIds)
        {

            foreach (var i in hbicCoopIds)
            {
                CoreFieldUserCoop coreFieldUserCoop = new CoreFieldUserCoop { UserId = userId, HbiccoopId = i };

                context.CoreFieldUserCoops.Add(coreFieldUserCoop);
            }
            context.SaveChanges();
        }

        public bool Delete_CoreFieldUserCoopByUserId(long userId)
        {
            var investmentList = context.CoreFieldUserCoops.Where(o => o.UserId == userId);
            if (investmentList != null && investmentList.Count() > 0)
            {
                context.CoreFieldUserCoops.RemoveRange(investmentList);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<CoreFieldUserCoop> Select_CoreFieldUserCoopByUserId(int userId)
        {
            var result = context.CoreFieldUserCoops.Where(o => o.UserId == userId).ToList();
            return result;
        }

        public async Task<List<CoreUser>> Select_UsersByAuthStatus(int? authStatus = null)
        {
            var result = new List<CoreUser>();
            if (authStatus != null)
                result = await context.CoreUsers.Where(o => o.AuthorizedStatus == authStatus && o.Role.ToLower() != "admin").OrderBy(o => o.UserName).ToListAsync();
            else
                result = await context.CoreUsers.Where(o => o.AuthorizedStatus > 0 && o.Role.ToLower() != "admin").OrderBy(o => o.UserName).ToListAsync();
            return result;
        }

        public async Task<List<CoreSubjectGroup>> Select_AllSubjectGroups()
        {
       
            var result = await context.CoreSubjectGroups.ToListAsync();
            return result;
        }

        public async Task<List<CoreSubject>> Select_SubjectsBySubjectGroupId(long groupId)
        {
            var result = await context.CoreSubjects.Where(o => o.GroupId == groupId).ToListAsync();
            return result;
        }

        //public async Task<List<CoreUser>> Select_UserByFilter(BOSearchModel search)
        //{
        //    var result = await context.CoreUsers.Where(o => search.ExpectedWorkId == o.ExpectedWork || (search.MinExpectedSalary =< double.Parse(o.ExpectedSalary) && search.MaxExpectedSalary >= double.Parse(o.ExpectedSalary))).AsNoTracking().ToListAsync();
        //    return result;
        //}
        #region Core_User
        public async Task<List<CoreUser>> Select_UsersByFilterSearch(BOSearch searchModel)
        {

            var result = context.CoreUsers.Where(x => x.AuthorizedStatus == 3).AsQueryable();
            if (searchModel != null)
            {
                if (searchModel.Gender.HasValue)
                    result = result.Where(x => x.Sex == Convert.ToBoolean(searchModel.Gender));
                if (searchModel.MinAuthorizedCapital.HasValue)
                    result = result.Where(x => x.AuthorizedCapital >= searchModel.MinAuthorizedCapital);
                if (searchModel.MaxAuthorizedCapital.HasValue)
                    result = result.Where(x => x.AuthorizedCapital <= searchModel.MaxAuthorizedCapital);
                if (searchModel.MinExpectedSalary.HasValue)
                    result = result.Where(x => x.ExpectedSalary >= searchModel.MinExpectedSalary);
                if (searchModel.MaxExpectedSalary.HasValue)
                    result = result.Where(x => x.ExpectedSalary <= searchModel.MaxExpectedSalary);
                if (searchModel.MinMobilizedCapital.HasValue)
                    result = result.Where(x => x.MobilizedCapital >= searchModel.MinMobilizedCapital);
                if (searchModel.MaxMobilizedCapital.HasValue)
                    result = result.Where(x => x.MobilizedCapital <= searchModel.MaxMobilizedCapital);
                if (searchModel.MinProceeds.HasValue)
                    result = result.Where(x => x.Proceeds >= searchModel.MinProceeds);
                if (searchModel.MaxProceeds.HasValue)
                    result = result.Where(x => x.Proceeds <= searchModel.MaxProceeds);
                if (searchModel.SpecialityGroupId.HasValue)
                    result = result.Where(x => x.SpecialityGroupId == searchModel.SpecialityGroupId);
                if (searchModel.SpecialityId.HasValue)
                    result = result.Where(x => x.SpecialityId == searchModel.SpecialityId);
                if (searchModel.GroupId.HasValue)
                    result = result.Where(x => x.GroupId == searchModel.GroupId);
                if (searchModel.EstablishYear.HasValue)
                    result = result.Where(x => x.EstablishYear == searchModel.EstablishYear);
                if (searchModel.SubjectId.HasValue)
                    result = result.Where(x => x.SubjectId == searchModel.SubjectId);
                if (!string.IsNullOrEmpty(searchModel.TitleCode) && !string.IsNullOrWhiteSpace(searchModel.TitleCode))
                    result = result.Where(x => x.Title.ToLower() == searchModel.TitleCode.ToLower());

            }
            return await result.ToListAsync();
        }

        public async Task Update_UsersAuthStatus(long[] userIds, short authStatus, DateTime? approvedDate = null)
        {
            var users = context.CoreUsers.Where(o => userIds.Contains(o.UserId)).ToList();
            users.ForEach(o => {
                o.AuthorizedStatus = authStatus;
                if(approvedDate != null)
                {
                    o.ApprovedDate = approvedDate;
                }
            });
            await context.SaveChangesAsync();
        }

        public bool Update_PorfolioFilePath(int userId, string filePath)
        {
            var user = context.CoreUsers.FirstOrDefault(o => o.UserId == userId);
            if (user != null)
            {
                user.PortfolioPath = filePath;
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update_FirmFilePath(int userId, string filePath)
        {
            var user = context.CoreUsers.FirstOrDefault(o => o.UserId == userId);
            if (user != null)
            {
                user.FirmProfilePath = filePath;
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Update_FinancialFilePath(int userId, string filePath)
        {
            var user = context.CoreUsers.FirstOrDefault(o => o.UserId == userId);
            if (user != null)
            {
                user.FinancialStatementFilePath = filePath;
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update_PasswordByEmail(string email, string passwordHash)
        {
            var user = context.CoreUsers.FirstOrDefault(o => o.Email == email);
            if (user != null)
            {
                user.PasswordHash = passwordHash;
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update_PasswordById(long userId, string passwordHash)
        {
            var user = context.CoreUsers.FirstOrDefault(o => o.UserId == userId);
            if (user != null)
            {
                user.PasswordHash = passwordHash;
                context.SaveChanges();
                return true;
            }
            return false;
        }


        #endregion

        #region Field_Speciality
        public async Task<List<FieldSpeciality>> Select_AllSpecialities()
        {
        
            var result = await context.FieldSpecialities.ToListAsync();
            return result;
        }
        #endregion

        #region Field_Title
        public async Task<List<FieldTitle>> Select_AllTitles()
        {
            var result = await context.FieldTitles.ToListAsync();
            return result;
        }
        #endregion

        #region Core_Subject
        public async Task<List<CoreSubject>> Select_AllSubjects()
        {
            var result = await context.CoreSubjects.ToListAsync();
            return result;
        }
        #endregion

        #region Field_File
        public FieldFile Insert_File(FieldFile newFile)
        {
            if (newFile != null)
            {
                var res = context.FieldFiles.Add(newFile);
                context.SaveChanges();
                if (res.Entity != null)
                    return res.Entity;
            }
            return null;
        }
        
        public async Task<bool> Delete_FilesByFileType(long userId, string fileType)
        {

            var files = await context.FieldFiles.Where(o => o.UserId == userId && o.FileType.ToLower() == fileType.ToLower()).ToListAsync();
            if(files != null && files.Count > 0)
            {
                files.Take(files.Count - 1).ToList().ForEach(o => o.IsDelete = true);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<FieldFile> Delete_File(long userId, string filePath)
        {
            var file = await context.FieldFiles.FirstOrDefaultAsync(o => o.UserId == userId && o.FilePath.Contains(filePath));
            if (file != null)
            {
                file.IsDelete = true;
                await context.SaveChangesAsync();
            }
            return file;
        }
        #endregion

        #region Field_InvestmentTypes
        public async Task<List<FieldInvestmentType>> Select_AllInvestmentTypes()
        {
            var result = await context.FieldInvestmentTypes.ToListAsync();
            return result;
        }
        #endregion

        #region Field_InvestmentSpeciality
        public async Task<List<FieldInvestmentSpeciality>> Select_AllInvestmentSpecialities()
        {
            var result = await context.FieldInvestmentSpecialities.ToListAsync();
            return result;
        }
        #endregion

        #region CoreFieldUserInvestmentSpec (User select investmentSpec)

        public async Task<bool> Insert_CoreFieldUserInvestmentSpec(long userId, string[] investmentSpecValues)
        {
            if(investmentSpecValues != null && investmentSpecValues.Count() > 0)
            {
                List<CoreFieldUserInvestmentSpec> userSelectList = new List<CoreFieldUserInvestmentSpec>();
                foreach (var i in investmentSpecValues)
                {
                    userSelectList.Add(new CoreFieldUserInvestmentSpec { UserId = userId, InvestmentSpecValue = i });
                }
                var userSelect = userSelectList.ToArray();
                await context.CoreFieldUserInvestmentSpecs.AddRangeAsync(userSelect);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public bool Delete_InvestmentSpecByUserId(long userId)
        {
            var investmentList = context.CoreFieldUserInvestmentSpecs.Where(o => o.UserId == userId);
            if (investmentList != null && investmentList.Count() > 0)
            {
                context.CoreFieldUserInvestmentSpecs.RemoveRange(investmentList);
                context.SaveChanges();
                return true;
            }
            return false;
        }


        public async Task<List<CoreFieldUserInvestmentSpec>> Select_InvestmentSpecsByUserId(long userId)
        {
            var result = await context.CoreFieldUserInvestmentSpecs.Include(o => o.InvestmentSpecValueNavigation).Where(o => o.UserId == userId).ToListAsync();
            return result;
        }
        #endregion

        #region CoreFieldUserInvestmentType (User select investmentType)
        public async Task<bool> Insert_CoreFieldUserInvestmentType(long userId, string[] investmentTypeValues)
        {
            if (investmentTypeValues != null && investmentTypeValues.Count() > 0)
            {
                List<CoreFieldUserInvestmentType> userSelectList = new List<CoreFieldUserInvestmentType>();
                foreach (var i in investmentTypeValues)
                {
                    userSelectList.Add(new CoreFieldUserInvestmentType { UserId = userId, InvestmentTypeValue = i });
                }
                var userSelect = userSelectList.ToArray();
                await context.CoreFieldUserInvestmentTypes.AddRangeAsync(userSelect);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }
        #endregion

        #region CoreLikeUsers
        public IQueryable Select_LikeList(long userId)
        {
            var result = context.CoreLikeUsers.Where(o => o.UserId == userId).AsQueryable();
            return result;
        }

        public bool CheckExist_LikeList(long userId, long userIdCheck)
        {
            var row = context.CoreLikeUsers.Where(o => o.UserId == userId && o.LikeUserId == userIdCheck).FirstOrDefault();
            return row != null;
        }

        public async Task<bool> AddLikeUser(long userId, long favUserId)
        {
            var result = await context.CoreLikeUsers.AddAsync(new CoreLikeUser { UserId = userId, LikeUserId = favUserId, CreatedDate = DateTime.Now });
            await context.SaveChangesAsync();
            return result != null;
        }

        public async Task<bool> DeleteLikeUser(long userId, long delUserId)
        {
            var row = await context.CoreLikeUsers.Where(o => o.UserId == userId && o.LikeUserId == delUserId).FirstOrDefaultAsync();
            var result = context.CoreLikeUsers.Remove(row);
            context.SaveChanges();
            return result != null;
        }
        #endregion

        public bool Delete_InvestmentTypesByUserId(long userId)
        {
            var investmentList = context.CoreFieldUserInvestmentTypes.Where(o => o.UserId == userId);
            if(investmentList != null && investmentList.Count() > 0)
            {
                context.CoreFieldUserInvestmentTypes.RemoveRange(investmentList);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public async Task<List<CoreFieldUserInvestmentType>> Select_InvestmentTypesByUserId(long userId)
        {
            var result = await context.CoreFieldUserInvestmentTypes.Include(o => o.InvestmentTypeValueNavigation).Where(o => o.UserId == userId).ToListAsync();
            return result;
        }
    }
}
