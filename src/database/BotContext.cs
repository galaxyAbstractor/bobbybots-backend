using bobbybots_backend.entity;
using Microsoft.EntityFrameworkCore;

namespace bobbybots_backend.database
{
    class BotContext : DbContext
    {
        public DbSet<Robot> Bots { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=bots.db");
        }
    }
}