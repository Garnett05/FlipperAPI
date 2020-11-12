using Flipper.Models;
using Microsoft.EntityFrameworkCore;

namespace Flipper.Data
{
    public class GroupsxUsersContext : DbContext
    {
        public GroupsxUsersContext(DbContextOptions<GroupsxUsersContext> opt) : base(opt)
        {

        }
        public DbSet<GroupsxUsers> GroupsxUsers { get; set; }
    }
}
