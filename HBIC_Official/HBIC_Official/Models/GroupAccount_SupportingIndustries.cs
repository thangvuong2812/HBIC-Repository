using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBIC_Official.Models
{
    public class GroupAccount_SupportingIndustries : GroupAccount_General
    {
        public string IndustrialArea { get; set; }
        public string ZIPCode { get; set; }
        public double Proceeds { get; set; } //Doanh thu
        public double Quantity { get; set; } //san luong
        public List<Machine> Machines { get; set; }

    }
}
