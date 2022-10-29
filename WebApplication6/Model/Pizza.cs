using System.Text.Json;
using System.Text.Json.Serialization;

namespace WebApplication6.Model
{
    public class Pizza
    {
        internal string name;
        internal string image;

        [JsonPropertyName("id")]    
        public int pizza_id { get; set; }
        public int Pizza_id { get; internal set; }
        [JsonPropertyName("name")]
        public string pizza_name { get; set; }
        [JsonPropertyName("image")]
        public string pizza_image { get; set; }

        public override string ToString()
        {
           return JsonSerializer.Serialize<Pizza>(this);

        }


    }
}
