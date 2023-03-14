using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.HBICModels
{
    public partial class FieldTitle
    {
        public FieldTitle()
        {
            CoreUsers = new HashSet<CoreUser>();
        }

        public long TitleId { get; set; }
        public string TitleCode { get; set; }
        public string TitleName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual ICollection<CoreUser> CoreUsers { get; set; }
    }
}
