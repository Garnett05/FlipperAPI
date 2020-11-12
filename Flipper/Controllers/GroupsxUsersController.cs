using System.Collections.Generic;
using AutoMapper;
using Flipper.Data;
using Flipper.Dtos;
using Flipper.Models;
using Microsoft.AspNetCore.Mvc;

namespace Flipper.Controllers
{
    [Route("api/groupsxusers")]
    [ApiController]
    public class GroupsxUsersController : ControllerBase
    {
        private readonly IGroupsxUsersRepo _repository;
        private readonly IMapper _mapper;
        public GroupsxUsersController(IGroupsxUsersRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        //GET api/groupsxusers
        [HttpGet]
        public ActionResult<IEnumerable<GroupsxUsersReadDto>> GetAllGroupsxUsers()
        {
            var groupsxUsersItems = _repository.GetAllGroupsxUsers();
            return Ok(_mapper.Map<IEnumerable<GroupsxUsersReadDto>>(groupsxUsersItems));
        }
        //GET api/groupsxusers/{id}
        [HttpGet("{id}", Name = "GetGroupsxUsersById")]
        public ActionResult <GroupsxUsersReadDto> GetGroupsxUsersById(int id)
        {
            var groupsxUsersItem = _repository.GetGroupsxUsersById(id);
            if (groupsxUsersItem != null)
            {
                return Ok(_mapper.Map<GroupsxUsersReadDto>(groupsxUsersItem));
            }
            return NotFound();
        }
        //POST api/groupsxusers
        [HttpPost]
        public ActionResult<GroupsxUsersReadDto> CreateGroupsxUsers(GroupsxUsersCreateDto groupsxUsersCreateDto)
        {
            var groupsxUsersModel = _mapper.Map<GroupsxUsers>(groupsxUsersCreateDto);
            _repository.CreateGroupsxUsers(groupsxUsersModel);
            _repository.SaveChanges();

            var groupsxUsersReadDto = _mapper.Map<GroupsxUsersReadDto>(groupsxUsersModel);

            return CreatedAtRoute(nameof(GetGroupsxUsersById), new { Id = groupsxUsersReadDto.Id }, groupsxUsersReadDto);
        }
        [HttpPut("{id}")]
        public ActionResult UpdateGroupsxUsers(int id, GroupsxUsersUpdateDto groupsxUsersUpdateDto)
        {
            var groupsxUsersModelFromRepo = _repository.GetGroupsxUsersById(id);
            if (groupsxUsersModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(groupsxUsersUpdateDto, groupsxUsersModelFromRepo);

            _repository.UpdateGroupsxUsers(groupsxUsersModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteGroupsxUsers(int id)
        {
            var groupsxUsersModelFromRepo = _repository.GetGroupsxUsersById(id);
            if (groupsxUsersModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteGroupsxUsers(groupsxUsersModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
    }
}
