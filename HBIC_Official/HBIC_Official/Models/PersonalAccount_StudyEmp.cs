using System;
using System.Collections.Generic;
using System.Text;

namespace HBIC_Official.Models
{
    public class PersonalAccount_StudyEmp : PersonalAccount_General
    {
        public string ExpectedWork { get; set; }
        public double? ExpectedSalary { get; set; }
        public string SchoolYear { get; set; }
        public List<AdditionSkill> AdditionSkills { get; set; }
        public string WorkDepartment { get; set; }

    }
}
