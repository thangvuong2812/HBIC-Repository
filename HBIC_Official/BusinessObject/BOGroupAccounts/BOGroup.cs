using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessObject.BOGroupAccounts
{
    public class BOGroup : BOUserBase
    {
        [Display(Name = "Họ tên người liên hệ")]
        [Required]
        public string FullName { get; set; }
        [Display(Name = "Tên tổ chức/công ty")]
        [Required]
        public string GroupCompanyName { get; set; }
        [Display(Name = "Mã số thuế")]
        public string TaxCode { get; set; }
        [Display(Name = "Ngày cấp mã số thuế")]
        public DateTime? TaxCodeTime { get; set; }
        [Display(Name = "Năm thành lập")]
        public int? EstablishYear { get; set; }
        [Display(Name = "Khối ngành học/công tá")]
        public long? SpecialityGroupId { get; set; }
        [Display(Name = "Chi tiết ngành/học công tác")]
        public long? SpecialityId { get; set; }
        [Display(Name = "Địa chỉ website của tổ chức")]
        public string WebsiteAddress { get; set; }
        [Display(Name = "Số lượng nhân viên")]
        public int? AttendeeNumber { get; set; }
        [Display(Name = "Tên bộ phận")]
        public string Department { get; set; }
    }
}
