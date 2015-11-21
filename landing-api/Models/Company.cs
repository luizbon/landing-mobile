using Newtonsoft.Json;

namespace Landing.Api.Models
{
    public class Company : BaseModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        [JsonProperty("website_url")]
        public string WebsiteUrl { get; set; }
    }
}