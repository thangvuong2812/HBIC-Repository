using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.HBICModels
{
    public partial class FieldInvestmentSpeciality
    {
        public FieldInvestmentSpeciality()
        {
            CoreFieldUserInvestmentSpecs = new HashSet<CoreFieldUserInvestmentSpec>();
        }

        public long SysId { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedBy { get; set; }

        public virtual ICollection<CoreFieldUserInvestmentSpec> CoreFieldUserInvestmentSpecs { get; set; }
    }
}
