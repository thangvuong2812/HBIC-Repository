using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.HBICModels
{
    public partial class FieldSpecialityGroup
    {
        public FieldSpecialityGroup()
        {
            FieldSpecialities = new HashSet<FieldSpeciality>();
        }

        public long SysId { get; set; }
        public string GroupName { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual ICollection<FieldSpeciality> FieldSpecialities { get; set; }
    }
}
