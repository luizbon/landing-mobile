using Newtonsoft.Json;

namespace Landing.Api.Models
{
    public class Referral : BaseModel
    {
        [JsonProperty("referred_name")]
        public string ReferredName { get; set; }

        [JsonProperty("referred_email")]
        public string ReferredEmail { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("related")]
        public string Related { get; set; }
    }
}