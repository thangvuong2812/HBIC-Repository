using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBIC_Official.Models
{
    public class GroupAccount_College : GroupAccount_General
    {
        public string Acchievement { get; set; }
        public bool? IsHired { get; set; }
        public List<Laboratory> Laboratories { get; set; }
        public List<Machine> Machines { get; set; }
        public List<string> ProjectsCompanyCoop { get; set; }
    }
}
