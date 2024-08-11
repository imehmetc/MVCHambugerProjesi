using AutoMapper;
using BLL.Dtos;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>().ForMember(dest => dest.AddressDtos, opt => opt.MapFrom(src => src.Addresses)).ReverseMap();
            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<Menu, MenuDto>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap(); 
            
            CreateMap<MenuDetail, MenuDetailDto>()
    .ForMember(dest => dest.MenuDto, opt => opt.MapFrom(src => src.Menu))
    .ForMember(dest => dest.ExtraItemDto, opt => opt.MapFrom(src => src.ExtraItem))
    .ReverseMap();

            CreateMap<ExtraItem, ExtraItemDto>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailDto>().ReverseMap();
        }
    }
}
