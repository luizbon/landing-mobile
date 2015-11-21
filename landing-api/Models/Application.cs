using Newtonsoft.Json;

namespace Landing.Api.Models
{
    public class Application : BaseModel
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("offer_id")]
        public int OfferId { get; set; }

        [JsonProperty("referral_requests_ids")]
        public int[] ReferralRequestsIds { get; set; }
    }
}