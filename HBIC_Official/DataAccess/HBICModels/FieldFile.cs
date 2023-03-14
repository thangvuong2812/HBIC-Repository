using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.HBICModels
{
    public partial class FieldFile
    {
        public long SysId { get; set; }
        public long? UserId { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsDelete { get; set; }

        public virtual CoreUser User { get; set; }
    }
}
