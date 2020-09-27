using Flipper.Models;
using Microsoft.EntityFrameworkCore;

namespace Flipper.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {

        }

        public DbSet<Games> Games { get; set; }
    }
}
