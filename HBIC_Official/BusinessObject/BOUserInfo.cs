
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class BOUserInfo
    {

        public long? UserId { get; set; }
        [Display(Name = "Họ tên đệm")]
        [Required(ErrorMessage = "Trường này bắt buộc!")]
        public string FirstName { get; set; } 
        [Display(Name = "Tên")]
        [Required(ErrorMessage = "Trường này bắt buộc!")]
        public string LastName { get; set; }
        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "Trường này bắt buộc!")]
        public string Address { get; set; } = null;
        [Display(Name = "Tỉnh thành")]
        public string City { get; set; } = null;
        [Display(Name = "Quận")]
        public string District { get; set; } = null;
        [Display(Name = "Quốc gia")]
        public string Country { get; set; } = null;
        [Display(Name = "Chức danh")]
        public string Title { get; set; } = null;
        [Display(Name = "Địa chỉ email")]
        [EmailAddress]
        public string Email { get; set; } = null;
        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Trường này bắt buộc!")]
        public string Telephone { get; set; } = null;
        [Display(Name = "Tên đăng nhập")]
        public string UserName { get; set; } = null;
        [Display(Name = "Trạng thái tài khoản")]
        public short? AuthorizedStatus { get; set; } = null;
        [Display(Name = "Ngày sinh")]
        public DateTime? BirthDay { get; set; } = null;
        [Display(Name = "Giới tính")]
        public bool? Sex { get; set; } = null;
        [Display(Name = "Mô tả bản thân")]
        public string Description { get; set; } = null;
        [Display(Name = "Id đối tượng")]
        public long? SubjectId { get; set; } = null;
        [Display(Name = "Họ tên người liên hệ")]
        public string FullName { get; set; } = null;
        [Display(Name = "Ảnh đại diện")]
        public string AvatarPath { get; set; }
        //public bool IsLockedOut { get; set; }
        //public DateTime? LockoutTime { get; set; }
        [Display(Name = "Mã chi tiết lĩnh vực liên quan")]
        public long? SpecialityId { get; set; } = null;
        [Display(Name = "Chi tiết lĩnh vực liên quan")]
        public string SpecialityTitle { get; set; } = null;
        [Display(Name = "Chứng chỉ đạt được")]
        public string Certificate { get; set; } = null;
        [Display(Name = "Tính chất công việc mong muốn")]
        public string ExpectedWork { get; set; } = null;
        [Display(Name = "Mức lương mong muốn")]
        public double? ExpectedSalary { get; set; } = null;
        [Display(Name = "Địa chỉ công tác")]
        public string AddressSchoolWork { get; set; } = null;
        [Display(Name = "Kỹ năng nổi bật")]
        public string ExtraSkill { get; set; } = null;
        [Display(Name = "Bộ phận đang công tác")]
        public string Department { get; set; } = null;
        [Display(Name = "Chức danh")]
        public string Role { get; set; } = null;
        [Display(Name = "Đường dẫn Porfolio/CV")]
        public string PortfolioPath { get; set; } = null;
        [Display(Name = "Nghề nghiệp")]
        public string Career { get; set; } = null;
        [Display(Name = "Niên khóa")]
        public string SchoolYear { get; set; } = null;
        [Display(Name = "Thành tựu đạt được")]
        public string Achievement { get; set; } = null;
        [Display(Name = "Tên tổ chức")]
        public string GroupCompanyName { get; set; } = null;
        [Display(Name = "Địa chỉ website")]
        public string WebsiteAddress { get; set; } = null;
        [Display(Name = "Năm thành lập")]
        public int? EstablishYear { get; set; } = null;
        [Display(Name = "Mã số thuế")]
        public string TaxCode { get; set; } = null;
        [Display(Name = "Ngày cấp mã số thuế")]
        public DateTime? TaxCodeTime { get; set; } = null;
        [Display(Name = "Số lượng nhân viên")]
        public int? AttendeeNumber { get; set; } = null;
        [Display(Name = "Trường/Viện nghiên cứu có sẵn sàng cho thuê phòng thí nghiệm & máy móc/thiết bị nghiên cứu không")]
        public bool? IsHired { get; set; } = null;
        [Display(Name = "Công ty có nhu cầu thuê phòng thí nghiệm, máy móc/thiết bị nghiên cứu không?")]
        public bool? IsNeedHired { get; set; } = null;
        [Display(Name = "Đã từng hợp tác nghiên cứu với tổ chức, dự án, công ty nào?")]
        public string ProjectsCompanyCoop { get; set; } = null;
        [Display(Name = "Khu công nghiệp")]
        public string IndustrialArea { get; set; } = null;
        [Display(Name = "Mã bưu điện")]
        public string Zipcode { get; set; } = null;
        [Display(Name = "Doanh thu")]
        public double? Proceeds { get; set; } = null;
        [Display(Name = "Sản lượng (sản phẩm/tháng)")]
        public double? Quantity { get; set; } = null;

        [Display(Name = "Vốn huy động")]
        public double? MobilizedCapital
        {
            get; set;
        } = null;
        [Display(Name = "Công ty đã tạo ra doanh thu hay chưa?")]
        public bool? IsProceeds { get; set; } = null;
        [Display(Name = "Giai đoạn phát triển")]
        public string DevelopmentStage { get; set; } = null;
        [Display(Name = "Thời điểm ra mắt sản phẩm đầu tiên")]
        public DateTime? FirstProductTime { get; set; } = null;
        [Display(Name = "Vốn điều lệ")]
        public double? AuthorizedCapital { get; set; } = null;
        [Display(Name = "Công ty gặp khó khăn trong việc tìm kiếm đối tác không?")]
        public bool? IsHardLookPartner { get; set; } = null;
        [Display(Name = "Công ty có nhu cầu tìm dịch vụ tư vấn từ các cố vấn trong ngành hay không??")]
        public bool? IsNeedAdvisory { get; set; } = null;
        [Display(Name = "Loại quỹ đầu tư")]
        public long? InvestmentFundId { get; set; } = null;
        [Display(Name = "Hội đồng quản trị")]
        public string AdministrativeCouncil { get; set; } = null;
        [Display(Name = "Số lượng công ty con")]
        public int? SubCompanyNumber { get; set; } = null;
        [Display(Name = "Đường dẫn hồ sơ công ty")]
        public string FirmProfilePath { get; set; } = null;
        [Display(Name = "Đường dẫn báo cáo tài chính của công ty")]
        public string FinancialStatementFilePath { get; set; } = null;
        [Display(Name = "Loại tài khoản")]
        public long? GroupId { get; set; } = null;
        [Display(Name = "Khối ngành liên quan")]
        public long? SpecialityGroupId { get; set; } = null;
        [Display(Name = "Loại tài khoản")]
        public string GroupTitle { get; set; } = null;
        [Display(Name = "Tên nhóm đối tượng")]
        public string SubjectTitle { get; set; } = null;
        [Display(Name = "Ngày tạo")]
        public DateTime? CreatedDate { get; set; } = null;
        [Display(Name = "Ngày gửi xác thực")]
        public DateTime? LastSubmittedDate { get; set; } = null;
        [Display(Name = "Ẩn địa chỉ mail")]
        public bool? IsHideEmail { get; set; } = null;
        [Display(Name = "Ẩn tên người liên hệ")]
        public bool? IsHideFullName { get; set; } = null;
        [Display(Name = "Ẩn số điện thoại")]
        public bool? IsHidePhoneNum { get; set; } = null;
        [Display(Name = "Ẩn thông tin phòng thí nghiệm")]
        public bool? IsHideLabs { get; set; } = null;
        [Display(Name = "Ẩn thông tin thiết bị")]
        public bool? IsHideMachines { get; set; } = null;
        [Display(Name = "Ẩn doanh thu")]
        public bool? IsHideProceeds { get; set; } = null;
        [Display(Name = "Ẩn hồ sơ công ty")]
        public bool? IsHideFirmProfile { get; set; } = null;
        [Display(Name = "Ẩn vốn điều lệ")]
        public bool? IsHideAuthorizedCapital { get; set; } = null;
        [Display(Name = "Ẩn vốn huy động")]
        public bool? IsHideMobilizedCapital { get; set; } = null;
        [Display(Name = "Danh sách các loại máy móc/thiết bị phục vụ cho việc nghiên cứu")]
        public string Machines { get; set; } = null;
        
        [Display(Name = "Tên hiển thị")]
        public string DisplayName { 
            get
            {
                string value = string.Empty;
                value = FirstName + ' ' + LastName;
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    value = GroupCompanyName;
                return value;
            }
        }
        [Display(Name = "Danh sách các phòng thí nghiệm và mục đích")]
        public string Laboratories { get; set; } = null;
        public IFormFile PorfolioFile { get; set; }
        public IFormFile FirmProfile { get; set; }
        public IFormFile FinancialStatementFile { get; set; }
        public List<SelectListItem> FieldHbicCoops { get; set; }

        public List<SelectListItem> InvestmentTypes { get; set; }
        public List<SelectListItem> InvestmentSpecs { get; set; }
        [Display(Name = "Loại quỹ đầu tư")]
        public string StrInvestmentTypes { get; set; }

        [Display(Name = "Lĩnh vực đầu tư")]
        public string StrInvestmentSpecs { get; set; }
    }
}
