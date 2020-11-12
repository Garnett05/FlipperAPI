using Flipper.Models;
using Microsoft.EntityFrameworkCore;

namespace Flipper.Data
{
    public class IconsGroupContext : DbContext
    {
        public IconsGroupContext(DbContextOptions<IconsGroupContext> opt) : base(opt)
        {

        }
        public DbSet<IconsGroup> IconsGroup { get; set; }
    }
}
