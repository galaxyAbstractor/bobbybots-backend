using System;
using System.Collections.Generic;
using bobbybots_backend.jsonconverters;
using GraphQL.Types;
using Newtonsoft.Json;

namespace bobbybots_backend.entity
{
    public class Robot {
        public string Name {get; set;}
        public string Id {get; set;}
        public int Score {get; set;}
        public string Image {get; set;}
        [JsonConverter(typeof(CategoryConverter))]
        public List<Category> Categories {get; set;}
    }

    public class RobotType : ObjectGraphType<Robot> {
        public RobotType() {
            Field(x => x.Name).Description("The name of the bot");
            Field(x => x.Id).Description("The id of the bot");
            Field(x => x.Score).Description("The score of the bot");
            Field(x => x.Image).Description("The image of the bot");
            Field<ListGraphType<CategoryType>>("categories", "The categories of the bot");
        }
    }
}