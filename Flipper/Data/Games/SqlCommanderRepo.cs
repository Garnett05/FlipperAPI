using Flipper.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Flipper.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public void CreateGame(Games game)
        {
            if (game == null)
            {
                throw new ArgumentNullException(nameof(game));
            }
            _context.Games.Add(game);
        }

        public void DeleteGame(Games game)
        {
            if (game == null)
            {
                throw new ArgumentNullException(nameof(game));
            }
            _context.Games.Remove(game);
        }

        public IEnumerable<Games> GetAllGames()
        {
            return _context.Games.ToList();
        }

        public Games GetGameById(int id)
        {
            return _context.Games.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateGame(Games game)
        {
            //Nothing 
        }
    }
}