using Flipper.Models;
using Microsoft.EntityFrameworkCore;

namespace Flipper.Data
{
    public class IconsUserContext : DbContext
    {
        public IconsUserContext(DbContextOptions<IconsUserContext> opt) : base(opt)
        {

        }
        public DbSet<IconsUser> IconsUser { get; set; }
    }
}
