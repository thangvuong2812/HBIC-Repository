using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBIC_Official.Code
{
    public class HBIC_Const
    {
        public enum AdminPages
        {
            Index, //Dashboard
            AccountManagement
        }
        public enum AuthorizedStatus
        {
            Unsubmit = 1,
            UnApproved,
            Approved,
            Deny
        }

        public enum Subjects
        {
            StudyEmp = 1,
            Researcher,
            College,
            SupportingIndustries,
            Startup,
            InvestmentFund,
            Coporation
        }
    }
}
