using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.HBICModels
{
    public partial class CoreLikeUser
    {
        public long SysId { get; set; }
        public long UserId { get; set; }
        public long LikeUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
