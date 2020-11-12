using AutoMapper;
using Flipper.Dtos;
using Flipper.Models;

namespace Flipper.Profiles
{
    public class IconsGroupProfile : Profile
    {
        public IconsGroupProfile()
        {
            //Source --> Target
            CreateMap<IconsGroup, IconsGroupReadDto>();
            CreateMap<IconsGroupCreateDto, IconsGroup>();
            CreateMap<IconsGroupUpdateDto, IconsGroup>();
        }
    }
}
