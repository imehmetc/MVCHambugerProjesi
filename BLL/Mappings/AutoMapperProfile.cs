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
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<Menu, MenuDto>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<MenuDetail, MenuDetailDto>().ReverseMap();
            CreateMap<ExtraItem, ExtraItemDto>().ReverseMap();
        }
    }
}
