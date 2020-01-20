using AutoMapper;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViewModels;

namespace MapperConfigure
{
    public class SourceProfile : Profile
    {
        public SourceProfile()
        {
            base.CreateMap<ShopingInfo, ShopingInfoViewModel>()
                .ForMember(a => a.Name, b =>
                {
                    b.MapFrom(c => c.ShopingName);
                }).ReverseMap();
        }
    }
}
