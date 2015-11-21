using Newtonsoft.Json;

namespace Landing.Api.Models
{
    public class Recomendation : BaseModel
    {
        [JsonProperty("offer_id")]
        public int OfferId { get; set; }
        [JsonProperty("sender")]
        public string Sender { get; set; }
        [JsonProperty("receiver")]
        public string Receiver { get; set; }
    }
}