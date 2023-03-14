using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessObject
{
    public class BOSettingsAccount
    {
        [Required]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "At least 6 characters!")]
        [Display(Name = "Mật khẩu hiện tại")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "At least 6 characters!")]
        [Display(Name = "Mật khẩu mới")]
        public string NewPassword { get; set; }
   
        [Required]
        [Display(Name = "Xác nhận mật khẩu")]
        [Compare("NewPassword", ErrorMessage = "Confirm new password doesn't match!")]
        public string ConfirmPassword { get; set; }

        public string ErrorMessage { get; set; }
        public string AvatarPath { get; set; }
        public IFormFile AvatarImage { get; set; }
    }
}
