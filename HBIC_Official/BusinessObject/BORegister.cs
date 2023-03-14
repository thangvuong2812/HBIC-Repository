using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessObject
{
    public class BORegister
    {
        [Required]
        [MinLength(6, ErrorMessage = "At least 6 characters!")]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "At least 6 characters!")]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match!")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please check policy agreement!")]
        public bool IsCheckPolicy { get; set; }
    }
}
