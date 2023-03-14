using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.HBICModels
{
    public partial class CoreSubject
    {
        public CoreSubject()
        {
            CoreFieldSubjectCoops = new HashSet<CoreFieldSubjectCoop>();
            CoreUsers = new HashSet<CoreUser>();
        }

        public long SysId { get; set; }
        public long GroupId { get; set; }
        public string Title { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual CoreSubjectGroup Group { get; set; }
        public virtual ICollection<CoreFieldSubjectCoop> CoreFieldSubjectCoops { get; set; }
        public virtual ICollection<CoreUser> CoreUsers { get; set; }
    }
}
