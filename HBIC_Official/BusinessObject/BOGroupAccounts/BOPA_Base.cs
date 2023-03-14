using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObject.BOGroupAccounts
{
    public class BOPA_Base
    {
        public string Email { get; set; }
        public string UserName { get; set; }

        public string Address { get; set; }
        public string Telephone { get; set; }

        //public short? AuthorizedStatus { get; set; }
        public long? SubjectId { get; set; }
        public string AvatarPath { get; set; }
        public long? SpecialityId { get; set; }
        public bool? IsHideFullName { get; set; }
        public List<SelectListItem> FieldHbicCoops { get; set; }
    }
}
