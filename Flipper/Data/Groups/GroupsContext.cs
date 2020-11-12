using Flipper.Models;
using Microsoft.EntityFrameworkCore;

namespace Flipper.Data
{
    public class GroupsContext : DbContext
    {
        public GroupsContext(DbContextOptions<GroupsContext> opt) : base(opt)
        {

        }
        public DbSet<Groups> Groups { get; set; }
    }
}
