using Flipper.Models;
using System.Collections.Generic;

namespace Flipper.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Games> GetAllGames();
        Games GetGameById(int id);
    }
}
