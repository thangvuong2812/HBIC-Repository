using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.HBICModels
{
    public partial class CoreFieldUserInvestmentType
    {
        public long SysId { get; set; }
        public long? UserId { get; set; }
        public string InvestmentTypeValue { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedBy { get; set; }

        public virtual FieldInvestmentType InvestmentTypeValueNavigation { get; set; }
        public virtual CoreUser User { get; set; }
    }
}
