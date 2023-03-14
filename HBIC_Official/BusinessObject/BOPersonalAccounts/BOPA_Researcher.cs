using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessObject.BOPersonalAccounts
{
    public class BOPA_Researcher : BOPersonal
    {
        [Display(Name = "Tỉnh thành")]
        [Required]
        public string City { get; set; }
        [Display(Name = "Đã từng hợp tác nghiên cứu với tổ chức, dự án nào")]
        public string ProjectsCompanyCoop { get; set; }

    }
}
