using AutoMapper;
using Flipper.Dtos;
using Flipper.Models;

namespace Flipper.Profiles
{
    public class GamesProfile : Profile
    {
        public GamesProfile()
        {
            //Source --> Target
            CreateMap<Games, GamesReadDto>();
            CreateMap<GamesCreateDto, Games>();
        }
    }
}
