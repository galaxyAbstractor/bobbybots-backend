using System;
using System.Collections.Generic;
using bobbybots_backend.entity;
using Newtonsoft.Json;

namespace bobbybots_backend.jsonconverters
{
    public class CategoryConverter : JsonConverter<List<Category>>
    {
        public override List<Category> ReadJson(JsonReader reader, Type objectType, List<Category> existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            List<Category> categories = new List<Category>();

            while (reader.ReadAsString() != null)
            {
                Category category = new Category();
                category.Name = (string)reader.Value;
                categories.Add(category);
            }

            return categories;
        }

        public override void WriteJson(JsonWriter writer, List<Category> value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}