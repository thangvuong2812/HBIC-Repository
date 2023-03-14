using AutoMapper;
using BusinessObject;
using BusinessObject.SearchViewModels;
using DataAccess.HBICModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HBIC_Official
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CoreUser, BOUserInfo>().ForMember(pts => pts.SpecialityTitle, opt => opt.MapFrom(ps => ps.Speciality.Title));
            CreateMap<CoreUser, BOShowDetailInfo>().ForMember(pts => pts.SpecialityTitle, opt => opt.MapFrom(ps => ps.Speciality.Title))
                .ForMember(des => des.Title, opt => opt.MapFrom(ps => ps.TitleNavigation.TitleName));
            
        }
    }
}
