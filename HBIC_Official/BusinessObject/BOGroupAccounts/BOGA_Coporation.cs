using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessObject.BOGroupAccounts
{
    public class BOGA_Coporation : BOGroup
    {
        [Display(Name = "Hồ sơ công ty")]
        public string FirmProfilePath { get; set; }
        [Required]
        public IFormFile FirmProfile { get; set; }
        [Display(Name = "Báo cáo tài chính")]
        public string FirmPFinancialStatementFilePathrofilePath { get; set; }
        [Required]
        public IFormFile FinancialStatementFile { get; set; }
        [Display(Name = "Tập đoàn có bao nhiêu công ty con?")]
        [Required]
        public int? SubCompanyNumber { get; set; }
        [Display(Name = "Liệt kê tất cả các công ty con")]
        [Required]
        public string SubCompanyName { get; set; }
        [Display(Name = "Đội ngũ hội đồng quản trị")]
        [Required]
        public string AdministrativeCouncil { get; set; }
    }
}
