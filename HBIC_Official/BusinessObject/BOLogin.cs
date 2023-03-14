using System;
using System.ComponentModel.DataAnnotations;

namespace BusinessObject
{
    public class BOLogin
    {
        [Required]
        [MinLength(3, ErrorMessage = "At least 3 characters!")]
        public string UserName { get; set; }
        //[Required]
        //[Display(Name = "Email")]
        //public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
       
    }
}
