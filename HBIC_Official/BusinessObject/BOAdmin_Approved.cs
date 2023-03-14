
using BusinessObject.SearchViewModels;

using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BusinessObject
{
    public class BOAdmin_Approved
    {

        public List<BOUserInfo> ApprovedUsers { get; set; } 
        public BOSearch SearchAccount { get; set; } = new BOSearch();
    }
}
