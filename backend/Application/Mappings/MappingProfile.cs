using Application.RequestObjects;
using Application.ResponseObjects;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<HeroRequestObject, HeroEntity>();
            CreateMap<HeroEntity, HeroResponseObject>();
        }
    }
}
