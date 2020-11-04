using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product,ProductToReturnDto>()
                .ForMember(dto => dto.ProductBrand, o => o.MapFrom(p => p.ProductBrand.Name))
                .ForMember(dto => dto.ProductType, o => o.MapFrom(p => p.ProductType.Name))
                .ForMember(dto => dto.PictureUrl, o => o.MapFrom<ProductUrlResolver>());
        }
    }
}