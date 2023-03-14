using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessObject.BOGroupAccounts
{
    public class BOGA_StartupFirm : BOGroup
    {
        [Display(Name = "Vốn huy động")]
        [Required]
        public double? MobilizedCapital { get; set; }
        [Display(Name = "Vốn điều lệ")]
        [Required]
        public double? AuthorizedCapital { get; set; }
        [Display(Name = "Công ty gặp khó khăn trong việc tìm kiếm đối tác không?")]
        public bool? IsHardLookPartner { get; set; }
        [Display(Name = "Công ty có nhu cầu tìm dịch vụ tư vấn từ các cố vấn trong ngành hay không?")]
        public bool? IsNeedAdvisory { get; set; }
        [Display(Name = "Công ty có nhu cầu thuê phòng thí nghiệm, máy móc/thiết bị nghiên cứu không?")]
        public bool? IsNeedHired { get; set; }
        [Display(Name = "Thời điểm ra mắt sản phẩm đầu tiên")]
        public DateTime? FirstProductTime { get; set; }
        [Display(Name = "Hồ sơ công ty")]
        public string FirmProfilePath { get; set; }
        [Required]
        public IFormFile FirmProfile { get; set; }


    }
}
