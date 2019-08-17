using System;
using Microsoft.EntityFrameworkCore;
using bobbybots_backend.entity;

namespace bobbybots_backend
{
    class BotContext : DbContext {
        public DbSet<Robot> Bots { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=bots.db");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
