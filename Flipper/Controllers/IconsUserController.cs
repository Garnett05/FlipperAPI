using System.Collections.Generic;
using AutoMapper;
using Flipper.Data;
using Flipper.Dtos;
using Flipper.Models;
using Microsoft.AspNetCore.Mvc;

namespace Flipper.Controllers
{
    [Route("api/iconsuser")]
    [ApiController]
    public class IconsUserController : ControllerBase
    {
        private readonly IIconsUserRepo _repository;
        private readonly IMapper _mapper;
        public IconsUserController(IIconsUserRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        //GET api/iconsuser
        [HttpGet]
        public ActionResult<IEnumerable<IconsUserReadDto>> GetAllIconsUser()
        {
            var iconsUserItems = _repository.GetAllIconsUser();
            return Ok(_mapper.Map<IEnumerable<IconsUserReadDto>>(iconsUserItems));
        }
        //GET api/iconsuser/{id}
        [HttpGet("{id}", Name = "GetIconsUserById")]
        public ActionResult <IconsUserReadDto> GetIconsUserById(int id)
        {
            var iconsUserItem = _repository.GetIconsUserById(id);
            if (iconsUserItem != null)
            {
                return Ok(_mapper.Map<IconsUserReadDto>(iconsUserItem));
            }
            return NotFound();
        }
        //POST api/iconsuser
        [HttpPost]
        public ActionResult<IconsUserReadDto> CreateIconsUser(IconsUserCreateDto iconsUserCreateDto)
        {
            var iconsUserModel = _mapper.Map<IconsUser>(iconsUserCreateDto);
            _repository.CreateIconsUser(iconsUserModel);
            _repository.SaveChanges();

            var iconsUserReadDto = _mapper.Map<IconsUserReadDto>(iconsUserModel);

            return CreatedAtRoute(nameof(GetIconsUserById), new { Id = iconsUserReadDto.IdIconUser }, iconsUserReadDto);
        }
        [HttpPut("{id}")]
        public ActionResult UpdateIconsUser(int id, IconsUserUpdateDto iconsUserUpdateDto)
        {
            var iconsUserModelFromRepo = _repository.GetIconsUserById(id);
            if (iconsUserModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(iconsUserUpdateDto, iconsUserModelFromRepo);

            _repository.UpdateIconsUser(iconsUserModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteIconsUser(int id)
        {
            var iconsUserModelFromRepo = _repository.GetIconsUserById(id);
            if (iconsUserModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteIconsUser(iconsUserModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
    }
}
