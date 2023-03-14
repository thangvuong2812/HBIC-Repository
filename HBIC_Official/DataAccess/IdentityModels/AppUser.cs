using DataAccess.HBICModels;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.IdentityModels
{
    public class AppUser : IdentityUser
    {

        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Country { get; set; }
        public string Title { get; set; }
        public short? AuthorizedStatus { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Sex { get; set; }
        public string Description { get; set; }
        public DateTime? LastPwdChanged { get; set; }
        public string ImagePath { get; set; }
        public long? SubjectId { get; set; }
        public string FullName { get; set; }
        public string AvatarPath { get; set; }
        public bool? IsLockedOut { get; set; }
        public DateTime? LockoutTime { get; set; }
        public long? SpecialityId { get; set; }
        public string Certificate { get; set; }
        public string ExpectedWork { get; set; }
        public string ExpectedSalary { get; set; }
        public string AddressSchoolWork { get; set; }
        public string ExtraSkill { get; set; }
        public string Department { get; set; }
        public string Role { get; set; }

        public virtual FieldSpeciality Speciality { get; set; }
        public virtual CoreSubject Subject { get; set; }
    }       
}
