using System.Collections.Generic;
using AutoMapper;
using Flipper.Data;
using Flipper.Dtos;
using Flipper.Models;
using Microsoft.AspNetCore.Mvc;

namespace Flipper.Controllers
{
    [Route("api/groups")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly IGroupsRepo _repository;
        private readonly IMapper _mapper;
        public GroupsController(IGroupsRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }        
        //GET api/groups
        [HttpGet]
        public ActionResult<IEnumerable<GroupsReadDto>> GetAllGroups()
        {
            var groupsItems = _repository.GetAllGroups();
            return Ok(_mapper.Map<IEnumerable<GroupsReadDto>>(groupsItems));
        }
        //GET api/groups/{id}
        [HttpGet("{id}", Name = "GetGroupById")]
        public ActionResult <GroupsReadDto> GetGroupById(int id)
        {
            var groupItem = _repository.GetGroupById(id);
            if (groupItem != null)
            {
                return Ok(_mapper.Map<GroupsReadDto>(groupItem));
            }
            return NotFound();
        }
        //POST api/groups
        [HttpPost]
        public ActionResult<GroupsReadDto> CreateGroup(GroupsCreateDto groupsCreateDto)
        {
            var groupModel = _mapper.Map<Groups>(groupsCreateDto);
            _repository.CreateGroup(groupModel);
            _repository.SaveChanges();

            var groupReadDto = _mapper.Map<GroupsReadDto>(groupModel);

            return CreatedAtRoute(nameof(GetGroupById), new { Id = groupReadDto.Id }, groupReadDto);
        }
        [HttpPut("{id}")]
        public ActionResult UpdateGroup (int id, GroupsUpdateDto groupsUpdateDto)
        {
            var groupModelFromRepo = _repository.GetGroupById(id);
            if (groupModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(groupsUpdateDto, groupModelFromRepo);

            _repository.UpdateGroup(groupModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteGroup(int id)
        {
            var groupModelFromRepo = _repository.GetGroupById(id);
            if (groupModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteGroup(groupModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
    }
}
