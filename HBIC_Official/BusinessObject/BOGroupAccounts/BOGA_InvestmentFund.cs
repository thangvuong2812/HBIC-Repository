using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessObject.BOGroupAccounts
{
    public class BOGA_InvestmentFund : BOGroup
    {
        [Display(Name = "Những lĩnh vực đầu tư")]
        public string[] InvestmentSectors { get; set; }

        [Display(Name = "Hồ sơ công ty")]
        public string FirmProfilePath { get; set; }
        [Required]
        public IFormFile FirmProfile { get; set; }
        [Display(Name = "Báo cáo tài chính")]
        public string FirmPFinancialStatementFilePathrofilePath { get; set; }
        [Required]
        public IFormFile FinancialStatementFile { get; set; }

        [Display(Name = "Các hình thức đầu tư")]
        public string[] InvestmentFundId { get; set; }

    }
}
