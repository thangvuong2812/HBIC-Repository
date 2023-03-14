using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessObject.BOGroupAccounts
{
    public class BOGA_College : BOGroup
    {
        [Display(Name = "Trường/Viện nghiên cứu có sẵn sàng cho thuê phòng thí nghiệm & máy móc/thiết bị nghiên cứu không")]
        [Required]
        public bool? IsHired { get; set; }
        [Display(Name = "Danh sách các phòng thí nghiệm và mục đích")]
        [Required]
        public string Laboratories { get; set; }
        [Display(Name = "Danh sách các loại máy móc/thiết bị phục vụ cho việc nghiên cứu")]
        [Required]
        public string Machines { get; set; }
        [Display(Name = "Đã từng hợp tác nghiên cứu với tổ chức, dự án, công ty nào?")]
        public string ProjectsCompanyCoop { get; set; }
        [Display(Name = "Thành tựu đạt được")]
        public string Achievement { get; set; }

    }
}
