using AutoMapper;
using Flipper.Dtos;
using Flipper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flipper.Profiles
{
    public class MessagesProfile : Profile
    {
        public MessagesProfile()
        {
            CreateMap<Messages, MessagesReadDto>();
            CreateMap<MessagesCreateDto, Messages>();
            CreateMap<MessagesUpdateDto, Messages>();            
        }
    }
}
