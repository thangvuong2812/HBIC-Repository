using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.HBICModels
{
    public partial class FieldHbiccoop
    {
        public FieldHbiccoop()
        {
            CoreFieldSubjectCoops = new HashSet<CoreFieldSubjectCoop>();
            CoreFieldUserCoops = new HashSet<CoreFieldUserCoop>();
        }

        public long SysId { get; set; }
        public string Title { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual ICollection<CoreFieldSubjectCoop> CoreFieldSubjectCoops { get; set; }
        public virtual ICollection<CoreFieldUserCoop> CoreFieldUserCoops { get; set; }
    }
}
