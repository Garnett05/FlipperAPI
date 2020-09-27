using Flipper.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Flipper.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Games> GetAllGames()
        {
            return _context.Games.ToList();
        }

        public Games GetGameById(int id)
        {
            return _context.Games.FirstOrDefault(x => x.Id == id);
        }
    }
}