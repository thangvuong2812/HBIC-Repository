using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBIC_Official.Models
{
    public class GroupAccount_StartupFirm : GroupAccount_General
    {
        public double MobilizedCapital { get; set; }
        public bool? IsProceeds { get; set; }
        public string DevelopmentStage { get; set; }
        public DateTime? FirstProductTime { get; set; }
        public double AuthorizedCapital { get; set; }
        public bool? IsHardLookPartner { get; set; }
        public bool? IsNeedAdvisory { get; set; }
    }
}
