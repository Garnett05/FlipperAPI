using Flipper.Models;
using Microsoft.EntityFrameworkCore;

namespace Flipper.Data
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> opt) : base(opt)
        {

        }
        public DbSet<Users> Users { get; set; }
    }
}
