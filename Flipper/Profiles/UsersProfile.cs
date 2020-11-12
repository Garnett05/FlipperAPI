using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Flipper.Dtos;
using Flipper.Models;

namespace Flipper.Profiles
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<Users, UsersReadDto>();
            CreateMap<UsersCreateDto, Users>();
            CreateMap<UsersUpdateDto, Users>();
        }
    }
}
