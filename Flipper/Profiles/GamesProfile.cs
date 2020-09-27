using AutoMapper;
using Flipper.Dtos;
using Flipper.Models;

namespace Flipper.Profiles
{
    public class GamesProfile : Profile
    {
        public GamesProfile()
        {
            CreateMap<Games, GamesReadDto>();
        }
    }
}
