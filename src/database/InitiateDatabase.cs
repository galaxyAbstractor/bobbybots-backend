using System.Collections.Generic;
using System.Linq;
using bobbybots_backend.entity;
using Newtonsoft.Json;

namespace bobbybots_backend.database
{
    public class InitiateDatabase {

        public static void loadBots() {
             var json = System.IO.File.ReadAllText("data/bots.json");

            var robots = JsonConvert.DeserializeObject<List<Robot>>(json);

            Dictionary<string, Category> categories = new Dictionary<string, Category>();

            using (var db = new BotContext()) {
                foreach (var robot in robots) {
                    var dbBot = db.Bots.Where(b => b.Id == robot.Id);

                    if (dbBot.Count() > 0) continue;

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