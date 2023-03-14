using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBIC_Official.Models
{
    public class GroupAccount_Coporation : GroupAccount_General
    {
        public string AdministrativeCouncil { get; set; }
        public int SubCompanyNumber { get; set; }
        public string FinancialStatementFilePath { get; set; }
    }
}
