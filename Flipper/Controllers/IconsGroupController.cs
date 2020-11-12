using System.Collections.Generic;
using AutoMapper;
using Flipper.Data;
using Flipper.Dtos;
using Flipper.Models;
using Microsoft.AspNetCore.Mvc;

namespace Flipper.Controllers
{
    [Route("api/iconsgroup")]
    [ApiController]
    public class IconsGroupController : ControllerBase
    {
        private readonly IIconsGroupRepo _repository;
        private readonly IMapper _mapper;
        public IconsGroupController(IIconsGroupRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        //GET api/iconsgroup
        [HttpGet]
        public ActionResult<IEnumerable<IconsGroupReadDto>> GetAllIconsGroup()
        {
            var iconsGroupItems = _repository.GetAllIconsGroup();
            return Ok(_mapper.Map<IEnumerable<IconsGroupReadDto>>(iconsGroupItems));
        }
        //GET api/iconsgroup/{id}
        [HttpGet("{id}", Name = "GetIconsGroupById")]
        public ActionResult <IconsGroupReadDto> GetIconsGroupById(int id)
        {
            var iconsGroupItem = _repository.GetIconsGroupById(id);
            if (iconsGroupItem != null)
            {
                return Ok(_mapper.Map<IconsGroupReadDto>(iconsGroupItem));
            }
            return NotFound();
        }
        //POST api/iconsgroup
        [HttpPost]
        public ActionResult<IconsGroupReadDto> CreateIconsGroup(IconsGroupCreateDto iconsGroupCreateDto)
        {
            var iconsGroupModel = _mapper.Map<IconsGroup>(iconsGroupCreateDto);
            _repository.CreateIconsGroup(iconsGroupModel);
            _repository.SaveChanges();

            var iconsGroupReadDto = _mapper.Map<IconsGroupReadDto>(iconsGroupModel);

            return CreatedAtRoute(nameof(GetIconsGroupById), new { Id = iconsGroupReadDto.IdIconGroup }, iconsGroupReadDto);
        }
        [HttpPut("{id}")]
        public ActionResult UpdateIconsGroup(int id, IconsGroupUpdateDto iconsGroupUpdateDto)
        {
            var iconsGroupModelFromRepo = _repository.GetIconsGroupById(id);
            if (iconsGroupModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(iconsGroupUpdateDto, iconsGroupModelFromRepo);

            _repository.UpdateIconsGroup(iconsGroupModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteIconsGroup(int id)
        {
            var iconsGroupModelFromRepo = _repository.GetIconsGroupById(id);
            if (iconsGroupModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteIconsGroup(iconsGroupModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
    }
}
