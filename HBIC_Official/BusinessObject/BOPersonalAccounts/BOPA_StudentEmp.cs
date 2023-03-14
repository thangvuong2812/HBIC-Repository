using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessObject.BOPersonalAccounts
{
    public class BOPA_StudentEmp : BOPersonal
    {
        [Display(Name ="Mức lương kỳ vọng")]
        public double? ExpectedSalary { get; set; }
        [Display(Name ="Tính chất công việc mong muốn")]
        [Required]
        public string ExpectedWork { get; set; }
        [Display(Name = "Niên khóa")]
        public string SchoolYear { get; set; }
        [Display(Name = "Phòng ban công tác")]
        public string Department { get; set; }
        [Display(Name = "Additional Skills")]
        public string ExtraSkill { get; set; }

    }
}
