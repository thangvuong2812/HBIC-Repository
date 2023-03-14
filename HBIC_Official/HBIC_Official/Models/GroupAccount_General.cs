using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBIC_Official.Models
{
    public class GroupAccount_General
    {
        public string GroupCompanyName { get; set; }
        public string WebsiteAddress { get; set; }
        public string Address { get; set; }
        public int EstablishYear { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactNumber { get; set; }
        public string TaxCode { get; set; }
        public DateTime? TaxCodeDate { get; set; }
        public string ContactEmail { get; set; }
        public List<HBICCooperation> HBICCooperations { get; set; }
        public string PortfolioPath { get; set; } //Duong dan ho so to chuc
        public int AttendeeNumber { get; set; }
        public string SpecializeName { get; set; } //Ten chuyen nganh
        public string DetailSpecializeName { get; set; } //Ten linh vuc thuoc chuyen nganh
    }
}
