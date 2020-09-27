using Flipper.Models;
using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Flipper.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        IEnumerable<Games> GetAllGames();
        Games GetGameById(int id);
        void CreateCommand(Games cmd);
    }
}
