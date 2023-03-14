using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBIC_Official.Models
{
    //Chuyen nganh
    public class Specialization
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public List<DetailSpecialization> DetailSpecializations { get; set; } //Cac linh vuc 
    }
}
