using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessObject
{
    public class BOShowDetailInfo
    {
        private const string HID_MESS = "******";
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

        private string _email;
        [Display(Name = "Địa chỉ email")]
        [EmailAddress]
        public string Email {
            get
            {
                if (IsHideEmail == true)
                    return HID_MESS;
                return _email;
            }

            set
            {
                _email = value;
            }
            
        }

        private string _telephone;
        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Trường này bắt buộc!")]
        public string Telephone {
            get
            {
                if (IsHidePhoneNum == true)
                    return HID_MESS;
                return _telephone;
            }
            set
            {
                _telephone = value;
            }
        }
        //[Display(Name = "Tên đăng nhập")]
        //public string UserName { get; set; } = null;
   

        [Display(Name = "Ngày sinh")]
        public DateTime? BirthDay { get; set; } = null;
        [Display(Name = "Giới tính")]
        public string Sex { get; set; }
        [Display(Name = "Mô tả bản thân")]
        public string Description { get; set; } = null;
        [Display(Name = "Họ tên người liên hệ")]
        public string FullName { get; set; } = null;
        [Display(Name = "Ảnh đại diện")]
        public string AvatarPath { get; set; }
        //public bool IsLockedOut { get; set; }
        //public DateTime? LockoutTime { get; set; }

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
        //[Display(Name = "Chức danh")]
        //public string Role { get; set; } = null;
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

        private string _proceeds;
        [Display(Name = "Doanh thu")]
        public string Proceeds { 
            get
            {
                if (IsHideProceeds == true)
                    return HID_MESS;
                return _proceeds;
            }

            set
            {
                _proceeds = value;
            }
        }
        [Display(Name = "Sản lượng (sản phẩm/tháng)")]
        public double? Quantity { get; set; } = null;

        private string _mobilizedCapital;
        [Display(Name = "Vốn huy động")]
        public string MobilizedCapital { 
            get 
            {
                if (IsHideMobilizedCapital == true)
                    return HID_MESS;
                return _mobilizedCapital;
            }
            set { _mobilizedCapital = value; }
        }
        [Display(Name = "Công ty đã tạo ra doanh thu hay chưa?")]
        public bool? IsProceeds { get; set; } = null;
        [Display(Name = "Giai đoạn phát triển")]
        public string DevelopmentStage { get; set; } = null;
        [Display(Name = "Thời điểm ra mắt sản phẩm đầu tiên")]
        public DateTime? FirstProductTime { get; set; } = null;


        private string _authorizedCapital;
        [Display(Name = "Vốn điều lệ")]
        public string AuthorizedCapital {
            get
            {
                if (IsHideAuthorizedCapital == true)
                    return HID_MESS;
                return _authorizedCapital;
            }
            set { _authorizedCapital = value; }
        }
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

        private string _firmProfilePath;
        [Display(Name = "Đường dẫn hồ sơ công ty")]
        public string FirmProfilePath { 
            get
            {
                if (IsHideFirmProfile == true)
                    return HID_MESS;
                return _firmProfilePath;
            }
            set
            {
                _firmProfilePath = value;
            }
        }
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
        //[Display(Name = "Ngày tạo")]
        //public DateTime? CreatedDate { get; set; } = null;
        //[Display(Name = "Ngày gửi xác thực")]
        //public DateTime? LastSubmittedDate { get; set; } = null;
        [Display(Name = "")]
        public bool? IsHideEmail { get; set; } = null;
        [Display(Name = "")]
        public bool? IsHideFullName { get; set; } = null;
        [Display(Name = "")]
        public bool? IsHidePhoneNum { get; set; } = null;
        [Display(Name = "")]
        public bool? IsHideLabs { get; set; } = null;
        [Display(Name = "")]
        public bool? IsHideMachines { get; set; } = null;
        [Display(Name = "")]
        public bool? IsHideProceeds { get; set; } = null;
        [Display(Name = "")]
        public bool? IsHideFirmProfile { get; set; } = null;
        [Display(Name = "")]
        public bool? IsHideAuthorizedCapital { get; set; } = null;
        [Display(Name = "")]
        public bool? IsHideMobilizedCapital { get; set; } = null;
        [Display(Name = "Danh sách các loại máy móc/thiết bị phục vụ cho việc nghiên cứu")]
        public string Machines { get; set; } = null;

        [Display(Name = "Tên hiển thị")]
        public string DisplayName
        {
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
       
        [Display(Name = "Loại quỷ đầu tư")]
        public string StrInvestmentTypes { get; set; }

        [Display(Name = "Lĩnh vực đầu tư")]
        public string StrInvestmentSpecs { get; set; }

        [Display(Name = "")]
        public bool IsLiked { get; set; }

    }
}

