using AutoMapper;
using EFwebapi.Dtos.Character;
using EFwebapi.Models;

namespace EFwebapi
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}