using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessObject.BOGroupAccounts
{
    public class BOGA_SupportingIndustries : BOGroup 
    {
        
        [Display(Name = "Quốc gia")]
        public string Country { get; set; }
        [Display(Name = "Tỉnh thành")]
        public string City { get; set; }
        [Display(Name = "Doanh thu")]
        public double? Proceeds { get; set; }
        
        [Display(Name = "Danh sách thiết bị")]
        public string Machines { get; set; }
        [Display(Name = "Mã bưu điện")]
        public string Zipcode { get; set; }
        [Display(Name = "Sản lượng (sản phẩm/tháng)")]
        public double? Quantity { get; set; }
        [Display(Name = "Hồ sơ công ty")]
        public string FirmProfilePath { get; set; }
        [Required]
        public IFormFile FirmProfile { get; set; }

    }
}
