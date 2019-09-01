using System;
using System.Collections.Generic;
using bobbybots_backend.jsonconverters;
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
}