using AutoMapper;
using BLL.Dtos;
using DAL.Entities;
using MVCHambugerProjesi.Models;

namespace MVCHambugerProjesi.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDto, UserViewModel>().ReverseMap();
            CreateMap<AddressDto, AddressViewModel>().ReverseMap();
            CreateMap<MenuDto, MenuViewModel>().ReverseMap();
            CreateMap<OrderDto, OrderViewModel>().ReverseMap();
            CreateMap<MenuDetailDto, MenuDetailViewModel>().ReverseMap();
            CreateMap<ExtraItemDto, ExtraItemViewModel>().ReverseMap();
        }
    }
}
