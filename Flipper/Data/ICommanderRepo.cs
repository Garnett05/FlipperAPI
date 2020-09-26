using Flipper.Models;
using System.Collections.Generic;

namespace Flipper.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}
