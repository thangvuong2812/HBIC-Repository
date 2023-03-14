using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBIC_Official.Models
{
    public class DetailSpecialization
    {
        public string ValueId { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string GroupName { get; set; }
        public string ValueGroupId { get; set; }
    }
}
