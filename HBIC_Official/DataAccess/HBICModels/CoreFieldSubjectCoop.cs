using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.HBICModels
{
    public partial class CoreFieldSubjectCoop
    {
        public long SysId { get; set; }
        public long? SubjectId { get; set; }
        public long? HbicCoopId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual FieldHbiccoop HbicCoop { get; set; }
        public virtual CoreSubject Subject { get; set; }
    }
}
