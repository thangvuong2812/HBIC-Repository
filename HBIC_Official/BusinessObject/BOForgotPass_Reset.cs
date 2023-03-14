using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessObject
{
    public class BOForgotPass_Reset : BOForgotPass_Email
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "At least 6 characters!")]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match!")]
        public string ConfirmPassword { get; set; }
    }
}
