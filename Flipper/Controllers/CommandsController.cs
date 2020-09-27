using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flipper.Data;
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

        public CommandsController (ICommanderRepo repository)
        {
            _repository = repository; 
        }
        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        //GET api/commands
        [HttpGet]        
        public ActionResult <IEnumerable<Games>> GetAllGames()
        {
            var gamesItems = _repository.GetAllGames();
            return Ok(gamesItems);
        }
        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Games> GetCommandById(int id)
        {
            var gamesItems = _repository.GetGameById(id);
            return Ok(gamesItems);
        }
    }
}
