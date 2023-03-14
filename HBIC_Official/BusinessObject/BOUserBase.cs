using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessObject
{
    public class BOUserBase
    {
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
       
        [Display(Name = "Tên đăng nhập")]
        public string UserName { get; set; }
        [Display(Name = "Địa chỉ")]
        [Required]
        public string Address { get; set; }
        [Display(Name = "Số điện thoại")]
        [Required]
        public string Telephone { get; set; }
        [Display(Name = "Giới tính")]
        [Required]
        public bool? Sex { get; set; }
        [Display(Name = "Tên loại tài khoản")]
        public string GroupTitle { get; set; }
        [Display(Name = "Loại tài khoản")]
        public long? GroupId { get; set; }
        [Display(Name = "Tên loại đối tượng")]
        public string SubjectTitle { get; set; }
        //public short? AuthorizedStatus { get; set; }
        [Display(Name = "Loại đối tượng")]
        public long? SubjectId { get; set; }
        public bool? IsHideEmail { get; set; }
        public bool? IsHidePhoneNum { get; set; }
        public bool? IsHideFullName { get; set; }
        public bool? IsHideLabs { get; set; }
        public bool? IsHideMachines { get; set; }
        public bool? IsHideProceeds { get; set; }
        public bool? IsHideFirmProfile { get; set; }
        public bool? IsHideAuthorizedCapital { get; set; }
        public bool? IsHideMobilizedCapital { get; set; }
        public string AvatarPath { get; set; }
        public List<SelectListItem> FieldHbicCoops { get; set; }
        
    }
}
