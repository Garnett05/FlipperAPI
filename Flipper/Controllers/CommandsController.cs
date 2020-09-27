using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Flipper.Data;
using Flipper.Dtos;
using Flipper.Models;
using Microsoft.AspNetCore.Mvc;

namespace Flipper.Controllers
{
    //api/commands
    [Route("api/games")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;
        private readonly IMapper _mapper;

        public CommandsController (ICommanderRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        //GET api/commands
        [HttpGet]        
        public ActionResult <IEnumerable<GamesReadDto>> GetAllGames()
        {
            var gamesItems = _repository.GetAllGames();
            return Ok(_mapper.Map<IEnumerable<GamesReadDto>>(gamesItems));
        }
        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <GamesReadDto> GetGameById(int id)
        {
            var gamesItems = _repository.GetGameById(id);
            if (gamesItems != null)
            {
                return Ok(_mapper.Map<GamesReadDto>(gamesItems));
            }
            return NotFound();
        }
    }
}
