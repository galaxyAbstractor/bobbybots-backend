using System;
using Microsoft.EntityFrameworkCore;
using bobbybots_backend.entity;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace bobbybots_backend
{
    class BotContext : DbContext
    {
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
            string json = System.IO.File.ReadAllText("data/bots.json");

            List<Robot> robots = JsonConvert.DeserializeObject<List<Robot>>(json);
        }
    }
}
