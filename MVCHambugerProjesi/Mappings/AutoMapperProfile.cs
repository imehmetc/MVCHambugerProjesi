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
            CreateMap<UserDto, UserViewModel>().ForMember(dest => dest.AddressViewModels, opt => opt.MapFrom(src => src.AddressDtos)).ReverseMap(); ;
            CreateMap<AddressDto, AddressViewModel>().ReverseMap();
            CreateMap<MenuDto, MenuViewModel>().ReverseMap();
            CreateMap<OrderDto, OrderViewModel>().ReverseMap();
            CreateMap<MenuDetailDto, MenuDetailViewModel>()
    .ForMember(dest => dest.MenuViewModel, opt => opt.MapFrom(src => src.MenuDto))
    .ForMember(dest => dest.ExtraItemViewModel, opt => opt.MapFrom(src => src.ExtraItemDto))
    .ReverseMap();

            CreateMap<ExtraItemDto, ExtraItemViewModel>().ForMember(a => a.MenuDetailViewModels, x => x.MapFrom(w => w.MenuDetailDtos)).ReverseMap();
            CreateMap<OrderDetailDto, OrderDetailViewModel>()
     .ForMember(dest => dest.AddressViewModel, opt => opt.MapFrom(src => src.AddressDto))
     .ForMember(dest => dest.ExtraItemViewModel, opt => opt.MapFrom(src => src.ExtraItemDto))
     .ForMember(dest => dest.MenuViewModel, opt => opt.MapFrom(src => src.MenuDto))
     .ForMember(dest => dest.OrderViewModel, opt => opt.MapFrom(src => src.OrderDto))
     .ReverseMap();
        }
    }
}
