using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessObject
{
    public class BOForgotPass_Email
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }

    }
}
