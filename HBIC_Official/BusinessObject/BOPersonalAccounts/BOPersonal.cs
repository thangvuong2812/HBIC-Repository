using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessObject.BOPersonalAccounts
{
    public class BOPersonal : BOUserBase
    {
        [Display(Name = "Chức danh")]
        [Required]
        public string Title { get; set; }
        [Display(Name = "Họ tên đệm")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Tên")]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Ngày sinh")]
        public DateTime? BirthDay { get; set; }
        [Display(Name = "Khối ngành học/công tác")]
        [Required]
        public long? SpecialityGroupId { get; set; }
        [Display(Name = "Chi tiết ngành/học công tác")]
        [Required]
        public long? SpecialityId { get; set; }
        [Display(Name = "Chứng chỉ đạt được")]
        public string Certificate { get; set; }
        [Display(Name = "CV/Porfolio")]
        public string PortfolioPath { get; set; }
        [Required]
        public IFormFile PorfolioFile { get; set; }
      
    }
}
