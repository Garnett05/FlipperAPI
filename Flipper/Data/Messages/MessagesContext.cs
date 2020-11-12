using Flipper.Models;
using Microsoft.EntityFrameworkCore;

namespace Flipper.Data
{
    public class MessagesContext : DbContext
    {
        public MessagesContext(DbContextOptions<MessagesContext> opt) : base(opt)
        {

        }
        public DbSet<Messages> Messages { get; set; }
    }
}
