using System.Collections.Generic;
using AutoMapper;
using Flipper.Data;
using Flipper.Dtos;
using Flipper.Models;
using Microsoft.AspNetCore.JsonPatch;
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
        [HttpGet("{id}", Name = "GetGameById")]
        public ActionResult <GamesReadDto> GetGameById(int id)
        {
            var gamesItems = _repository.GetGameById(id);
            if (gamesItems != null)
            {
                return Ok(_mapper.Map<GamesReadDto>(gamesItems));
            }
            return NotFound();
        }
        //POST api/games
        [HttpPost]
        public ActionResult<GamesReadDto> CreateGame(GamesCreateDto gameCreateDto)
        {
            var gameModel = _mapper.Map<Games>(gameCreateDto);
            _repository.CreateGame(gameModel);
            _repository.SaveChanges();

            var gameReadDto = _mapper.Map<GamesReadDto>(gameModel);

            return CreatedAtRoute(nameof(GetGameById), new { Id = gameReadDto.Id }, gameReadDto);            
        }
        //PUT api/games/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateGame (int id, GamesUpdateDto gameUpdateDto)
        {
            var gameModelFromRepo = _repository.GetGameById(id);
            if (gameModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(gameUpdateDto, gameModelFromRepo);

            _repository.UpdateGame(gameModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
        //PATCH api/games/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialGameUpdate (int id, JsonPatchDocument<GamesUpdateDto> patchDoc)
        {
            var gameModelFromRepo = _repository.GetGameById(id);
            if (gameModelFromRepo == null)
            {
                return NotFound();
            }

            var gameToPatch = _mapper.Map<GamesUpdateDto>(gameModelFromRepo);
            if (ModelState.IsValid)
            {
                patchDoc.ApplyTo(gameToPatch, ModelState);
                if (!TryValidateModel(gameToPatch))
                {
                    return ValidationProblem(ModelState);
                }
                _mapper.Map(gameToPatch, gameModelFromRepo);
                _repository.UpdateGame(gameModelFromRepo);
                _repository.SaveChanges();
                return NoContent();
            }
            return NotFound();
        }
        
        //DELE api/games/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteGame(int id)
        {
            var gameModelFromRepo = _repository.GetGameById(id);
            if (gameModelFromRepo == null){
                return NotFound();
            }
            _repository.DeleteGame(gameModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }

    }
}
