using System.Collections.Generic;
using AutoMapper;
using Flipper.Data;
using Flipper.Dtos;
using Flipper.Models;
using Microsoft.AspNetCore.Mvc;

namespace Flipper.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepo _repository;
        private readonly IMapper _mapper;
        public UsersController(IUsersRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }        
        //GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<UsersReadDto>> GetAllUsers()
        {
            var usersItems = _repository.GetAllUsers();
            return Ok(_mapper.Map<IEnumerable<UsersReadDto>>(usersItems));
        }
        //GET api/users/{id}
        [HttpGet("{id}", Name = "GetUserById")]
        public ActionResult <UsersReadDto> GetUserById(int id)
        {
            var userItem = _repository.GetUserById(id);
            if (userItem != null)
            {
                return Ok(_mapper.Map<UsersReadDto>(userItem));
            }
            return NotFound();
        }
        //POST api/user
        [HttpPost]
        public ActionResult<UsersReadDto> CreateUser(UsersCreateDto usersCreateDto)
        {
            var userModel = _mapper.Map<Users>(usersCreateDto);
            _repository.CreateUser(userModel);
            _repository.SaveChanges();

            var userReadDto = _mapper.Map<UsersReadDto>(userModel);

            return CreatedAtRoute(nameof(GetUserById), new { Id = userReadDto.Id }, userReadDto);
        }
        [HttpPut("{id}")]
        public ActionResult UpdateUser (int id, UsersUpdateDto usersUpdateDto)
        {
            var userModelFromRepo = _repository.GetUserById(id);
            if (userModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(usersUpdateDto, userModelFromRepo);

            _repository.UpdateUser(userModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            var userModelFromRepo = _repository.GetUserById(id);
            if (userModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteUser(userModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
    }
}
