using Flipper.Models;
using System.Collections.Generic;

namespace Flipper.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }
}
