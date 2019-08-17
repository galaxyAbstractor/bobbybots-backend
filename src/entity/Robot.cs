using System.Collections.Generic;

namespace bobbybots_backend.entity {
    public class Robot {
        public string Name {get; set;}
        public string Id {get; set;}
        public int Score {get; set;}
        public string Image {get; set;}
        public List<Category> Categories {get; set;}
    }
}