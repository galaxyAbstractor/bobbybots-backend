using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace bobbybots_backend.entity {

    [Table("Categories")]
    public class Category {
        public string Name {get; set;}
        
        [JsonIgnore]        
        public long Id {get; set;}
    }
}