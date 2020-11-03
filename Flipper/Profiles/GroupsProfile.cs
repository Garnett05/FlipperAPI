using AutoMapper;
using Flipper.Dtos;
using Flipper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flipper.Profiles
{
    public class GroupsProfile : Profile
    {
        public GroupsProfile()
        {
            CreateMap<Groups, GroupsReadDto>();
            CreateMap<GroupsCreateDto, Groups>();
            CreateMap<GroupsUpdateDto, Groups>();            
        }
    }
}
