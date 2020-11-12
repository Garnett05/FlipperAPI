using AutoMapper;
using Flipper.Dtos;
using Flipper.Models;

namespace Flipper.Profiles
{
    public class IconsUserProfile : Profile
    {
        public IconsUserProfile()
        {
            //Source --> Target
            CreateMap<IconsUser, IconsUserReadDto>();
            CreateMap<IconsUserCreateDto, IconsUser>();
            CreateMap<IconsUserUpdateDto, IconsUser>();
        }
    }
}
