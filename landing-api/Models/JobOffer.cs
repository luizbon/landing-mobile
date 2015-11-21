using System;
using Newtonsoft.Json;

namespace Landing.Api.Models
{
    public class JobOffer : BaseModel
    {
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("company_id")]
        public int CompanyId { get; set; }
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
        [JsonProperty("country_name")]
        public string CountryName { get; set; }
        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }
        [JsonProperty("expires_at")]
        public DateTime ExpiresAt { get; set; }
        [JsonProperty("nice_to_have")]
        public string NiceToHave { get; set; }
        [JsonProperty("perks")]
        public string Perks { get; set; }
        [JsonProperty("published_at")]
        public DateTime PublishedAt { get; set; }
        [JsonProperty("reward")]
        public double Reward { get; set; }
        [JsonProperty("remote")]
        public bool Remote { get; set; }
        [JsonProperty("relocation_paid")]
        public bool RelocationPaid { get; set; }
        [JsonProperty("role_description")]
        public string RoleDescription { get; set; }
        [JsonProperty("salary_low")]
        public double? SalaryLow { get; set; }
        [JsonProperty("salary_high")]
        public double? SalaryHigh { get; set; }
        [JsonProperty("successful")]
        public bool Successful { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("work_from_home")]
        public bool WorkFromHome { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }
}