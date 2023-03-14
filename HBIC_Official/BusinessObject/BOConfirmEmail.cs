using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessObject
{
    public class BOConfirmEmail
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string AuthCode { get; set; }
    }
}
