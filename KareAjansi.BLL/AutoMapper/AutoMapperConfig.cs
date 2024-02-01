using AutoMapper;
using KareAjansi.BLL.DTOs;
using KareAjansi.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansi.BLL.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            //Mapleme
            CreateMap<Manken, MankenDTO>().ReverseMap();
            CreateMap<Organizasyon, OrganizasyonDTO>().ReverseMap();
            CreateMap<OrganizasyonManken, OrganizasyonMankenDTO>().ReverseMap();
            CreateMap<Odeme, OdemeDTO>().ReverseMap();
            CreateMap<Yorum, YorumDTO>().ReverseMap();
        }
    }
}