using Microsoft.EntityFrameworkCore;
using bobbybots_backend.entity;
using System.Collections;
using Newtonsoft.Json;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System;

namespace bobbybots_backend
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

    class Program
    {
        static void Main(string[] args)
        {
            var json = System.IO.File.ReadAllText("data/bots.json");

            var robots = JsonConvert.DeserializeObject<List<Robot>>(json);

            Dictionary<string, Category> categories = new Dictionary<string, Category>();

            using (var db = new BotContext()) {

                foreach (var robot in robots) {
                    var populatedCategories = new List<Category>();

                    foreach (var category in robot.Categories) {
                        if (categories.ContainsKey(category.Name.ToLower())) {
                            populatedCategories.Add(categories[category.Name.ToLower()]);
                        } else {
                            db.Categories.Add(category);
                            db.SaveChanges();

                            categories[category.Name.ToLower()] = category;
                        }
                    }

                    robot.Categories = populatedCategories;

                    db.Bots.Add(robot);

                    db.SaveChanges();
                }
            }
        }
    }
}
