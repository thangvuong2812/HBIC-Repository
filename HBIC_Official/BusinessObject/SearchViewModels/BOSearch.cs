
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessObject.SearchViewModels
{
    public class BOSearch
    {
        [Display(Name = "Chi tiết ngành nghề")]
        public int? SpecialityId { get; set; }
        [Display(Name = "Khối ngành")]
        public int? SpecialityGroupId { get; set; }
        [Display(Name = "Thành tựu")]
        public int? AcchievementId { get; set; }
        [Display(Name = "Chức danh")]
        public string TitleCode { get; set; }
        public List<int> HbicCoopId { get; set; }
        [Display(Name = "Loại tài khoản")]
        public int? GroupId { get; set; }
        [Display(Name = "Đổi tượng")]
        public int? SubjectId { get; set; }
        [Display(Name = "Doanh thu tối thiểu")]
        public double? MinProceeds { get; set; }
        [Display(Name = "Doanh thu tối đa")]
        public double? MaxProceeds { get; set; }
        [Display(Name = "Vốn huy động tối đa")]
        public double? MaxMobilizedCapital { get; set; } //von huy dong
        [Display(Name = "Vốn huy động tối thiểu")]
        public double? MinMobilizedCapital { get; set; }
        [Display(Name = "Vốn điều lệ tối đa")]
        public double? MaxAuthorizedCapital { get; set; } //von dieu le
        [Display(Name = "Vốn điều lệ tối thiểu")]
        public double? MinAuthorizedCapital { get; set; }
        [Display(Name = "Năm thành lập")]
        public int? EstablishYear { get; set; }
        [Display(Name = "Lương tối thiểu")]
        public double? MinExpectedSalary { get; set; }
        [Display(Name = "Lương tối đa")]
        public double? MaxExpectedSalary { get; set; }
        [Display(Name = "Công việc mong muốn")]
        public string ExpectedWorkId { get; set; }
        [Display(Name = "Giới tính")]
        public int? Gender { get; set; }
        
        public List<SelectListItem> SpecialityGroups { get; set; }
        public List<SelectListItem> Specialities { get; set; }
        public List<SelectListItem> SubjectGroups { get; set; }
        public List<SelectListItem> Subjects { get; set; }
        public List<SelectListItem> Titles { get; set; }

    }
}
