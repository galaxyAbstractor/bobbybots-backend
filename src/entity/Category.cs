using Newtonsoft.Json;

namespace bobbybots_backend.entity {
    public class Category {
        public string Name {get; set;}
        
        [JsonIgnore]        
        public long Id {get; set;}
    }
}