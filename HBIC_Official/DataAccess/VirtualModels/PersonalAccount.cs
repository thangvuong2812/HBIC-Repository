using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.VirtualModels
{
    public class PersonalAccount : GeneralPersonalAccount
    {
        public string ExpectedJob { get; set; }
        public double? ExpectedSalary { get; set; }
        public string SchoolYear { get; set; }
        public List<AdditionSkill> AdditionSkills { get; set; }
        public string WorkDepartment { get; set; }
        public List<HBICCooperation> HBICCooperations { get; set; }
    }
}
