using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.HBICModels
{
    public partial class CoreSubjectGroup
    {
        public CoreSubjectGroup()
        {
            CoreSubjects = new HashSet<CoreSubject>();
            CoreUsers = new HashSet<CoreUser>();
        }

        public long GroupId { get; set; }
        public string GroupTitle { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual ICollection<CoreSubject> CoreSubjects { get; set; }
        public virtual ICollection<CoreUser> CoreUsers { get; set; }
    }
}
