using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Flipper.Dtos;
using Flipper.Models;

namespace Flipper.Profiles
{
    public class GroupsxUsersProfile : Profile
    {
        public GroupsxUsersProfile()
        {
            CreateMap<GroupsxUsers, GroupsxUsersReadDto>();
            CreateMap<GroupsxUsersCreateDto, GroupsxUsers>();
            CreateMap<GroupsxUsersUpdateDto, GroupsxUsers>();
        }
    }
}
