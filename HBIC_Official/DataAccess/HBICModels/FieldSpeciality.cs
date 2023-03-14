using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.HBICModels
{
    public partial class FieldSpeciality
    {
        public FieldSpeciality()
        {
            CoreUsers = new HashSet<CoreUser>();
        }

        public long SpecialityId { get; set; }
        public string Title { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public long SpecialityGroupId { get; set; }

        public virtual FieldSpecialityGroup SpecialityGroup { get; set; }
        public virtual ICollection<CoreUser> CoreUsers { get; set; }
    }
}
