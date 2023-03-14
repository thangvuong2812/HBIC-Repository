using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.HBICModels
{
    public partial class CoreFieldUserCoop
    {
        public long SysId { get; set; }
        public long? UserId { get; set; }
        public long? HbiccoopId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual FieldHbiccoop Hbiccoop { get; set; }
        public virtual CoreUser User { get; set; }
    }
}
