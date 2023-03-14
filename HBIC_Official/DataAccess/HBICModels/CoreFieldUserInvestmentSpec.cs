using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.HBICModels
{
    public partial class CoreFieldUserInvestmentSpec
    {
        public long SysId { get; set; }
        public long? UserId { get; set; }
        public string InvestmentSpecValue { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual FieldInvestmentSpeciality InvestmentSpecValueNavigation { get; set; }
        public virtual CoreUser User { get; set; }
    }
}
