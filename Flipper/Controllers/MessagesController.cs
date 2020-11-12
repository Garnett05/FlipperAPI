using System.Collections.Generic;
using AutoMapper;
using Flipper.Data;
using Flipper.Dtos;
using Flipper.Models;
using Microsoft.AspNetCore.Mvc;

namespace Flipper.Controllers
{
    [Route("api/messages")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessagesRepo _repository;
        private readonly IMapper _mapper;
        public MessagesController(IMessagesRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        //GET api/messages
        [HttpGet]
        public ActionResult<IEnumerable<MessagesReadDto>> GetAllMessages()
        {
            var messagesItems = _repository.GetAllMessages();
            return Ok(_mapper.Map<IEnumerable<MessagesReadDto>>(messagesItems));
        }
        //GET api/messages/{id}
        [HttpGet("{id}", Name = "GetMessagesById")]
        public ActionResult <MessagesReadDto> GetMessagesById(int id)
        {
            var messagesItem = _repository.GetMessagesById(id);
            if (messagesItem != null)
            {
                return Ok(_mapper.Map<MessagesReadDto>(messagesItem));
            }
            return NotFound();
        }
        //POST api/messages
        [HttpPost]
        public ActionResult<MessagesReadDto> CreateMessages(MessagesCreateDto messagesCreateDto)
        {
            var messagesModel = _mapper.Map<Messages>(messagesCreateDto);
            _repository.CreateMessages(messagesModel);
            _repository.SaveChanges();

            var messagesReadDto = _mapper.Map<MessagesReadDto>(messagesModel);

            return CreatedAtRoute(nameof(GetMessagesById), new { Id = messagesReadDto.IdMsg }, messagesReadDto);
        }
        [HttpPut("{id}")]
        public ActionResult UpdateMessages(int id, MessagesUpdateDto messagesUpdateDto)
        {
            var messagesModelFromRepo = _repository.GetMessagesById(id);
            if (messagesModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(messagesUpdateDto, messagesModelFromRepo);

            _repository.UpdateMessages(messagesModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteMessages(int id)
        {
            var messagesModelFromRepo = _repository.GetMessagesById(id);
            if (messagesModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteMessages(messagesModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
    }
}
