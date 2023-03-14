using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.HBICModels
{
    public partial class CoreUser
    {
        public CoreUser()
        {
            CoreFieldUserCoops = new HashSet<CoreFieldUserCoop>();
            CoreFieldUserInvestmentSpecs = new HashSet<CoreFieldUserInvestmentSpec>();
            CoreFieldUserInvestmentTypes = new HashSet<CoreFieldUserInvestmentType>();
            FieldFiles = new HashSet<FieldFile>();
        }

        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Country { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public short? AuthorizedStatus { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? BirthDay { get; set; }
        public bool? Sex { get; set; }
        public string Description { get; set; }
        public DateTime? LastPwdChanged { get; set; }
        public long? SubjectId { get; set; }
        public string FullName { get; set; }
        public string AvatarPath { get; set; }
        public bool? IsLockedOut { get; set; }
        public DateTime? LockoutTime { get; set; }
        public long? SpecialityId { get; set; }
        public string Certificate { get; set; }
        public string ExpectedWork { get; set; }
        public double? ExpectedSalary { get; set; }
        public string AddressSchoolWork { get; set; }
        public string ExtraSkill { get; set; }
        public string Department { get; set; }
        public string Role { get; set; }
        public bool? IsConfirmEmail { get; set; }
        public string EmailCode { get; set; }
        public DateTime? EmailCodeTime { get; set; }
        public string PortfolioPath { get; set; }
        public string Career { get; set; }
        public string SchoolYear { get; set; }
        public string Achievement { get; set; }
        public string GroupCompanyName { get; set; }
        public string WebsiteAddress { get; set; }
        public int? EstablishYear { get; set; }
        public string TaxCode { get; set; }
        public DateTime? TaxCodeTime { get; set; }
        public int? AttendeeNumber { get; set; }
        public bool? IsHired { get; set; }
        public string ProjectsCompanyCoop { get; set; }
        public string IndustrialArea { get; set; }
        public string Zipcode { get; set; }
        public double? Proceeds { get; set; }
        public double? Quantity { get; set; }
        public double? MobilizedCapital { get; set; }
        public bool? IsProceeds { get; set; }
        public string DevelopmentStage { get; set; }
        public DateTime? FirstProductTime { get; set; }
        public double? AuthorizedCapital { get; set; }
        public bool? IsHardLookPartner { get; set; }
        public bool? IsNeedAdvisory { get; set; }
        public long? InvestmentFundId { get; set; }
        public string AdministrativeCouncil { get; set; }
        public int? SubCompanyNumber { get; set; }
        public string ImagePath { get; set; }
        public string FirmProfilePath { get; set; }
        public string FinancialStatementFilePath { get; set; }
        public long? GroupId { get; set; }
        public long? SpecialityGroupId { get; set; }
        public string GroupTitle { get; set; }
        public string SubjectTitle { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsHideEmail { get; set; }
        public bool? IsHideFullName { get; set; }
        public bool? IsHidePhoneNum { get; set; }
        public bool? IsHideLabs { get; set; }
        public bool? IsHideMachines { get; set; }
        public bool? IsHideProceeds { get; set; }
        public bool? IsHideFirmProfile { get; set; }
        public bool? IsHideAuthorizedCapital { get; set; }
        public bool? IsHideMobilizedCapital { get; set; }
        public string Machines { get; set; }
        public string Laboratories { get; set; }
        public string ResetPassCode { get; set; }
        public DateTime? ResetPassCodeTime { get; set; }
        public bool? IsNeedHired { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? LastSubmittedDate { get; set; }

        public virtual CoreSubjectGroup Group { get; set; }
        public virtual FieldSpeciality Speciality { get; set; }
        public virtual CoreSubject Subject { get; set; }
        public virtual FieldTitle TitleNavigation { get; set; }
        public virtual ICollection<CoreFieldUserCoop> CoreFieldUserCoops { get; set; }
        public virtual ICollection<CoreFieldUserInvestmentSpec> CoreFieldUserInvestmentSpecs { get; set; }
        public virtual ICollection<CoreFieldUserInvestmentType> CoreFieldUserInvestmentTypes { get; set; }
        public virtual ICollection<FieldFile> FieldFiles { get; set; }
    }
}
