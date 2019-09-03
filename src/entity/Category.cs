using System.ComponentModel.DataAnnotations.Schema;
using GraphQL.Types;
using Newtonsoft.Json;

namespace bobbybots_backend.entity {

    [Table("Categories")]
    public class Category {
        public string Name {get; set;}
        
        [JsonIgnore]        
        public long Id {get; set;}
    }

    public class CategoryType : ObjectGraphType<Category> {
        public CategoryType() {
            Field(x => x.Name).Description("The name of the category");
            Field(x => x.Id).Description("The id of the category");
        }
    }
}