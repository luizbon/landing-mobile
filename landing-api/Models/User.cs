using Newtonsoft.Json;

namespace Landing.Api.Models
{
    public class User : BaseModel
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("birth_year")]
        public int BirthYear { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("headline")]
        public string Headline { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("salary_expectation")]
        public int SalaryExpectation { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("languages")]
        public string[] Languages { get; set; }

        [JsonProperty("skills")]
        public string[] Skills { get; set; }

        [JsonProperty("focus_skills")]
        public string[] FocusSkills { get; set; }

        [JsonProperty("relocation_countries")]
        public string[] RelocationCountries { get; set; }

        [JsonProperty("availability")]
        public string Availability { get; set; }

        [JsonProperty("websites")]
        public Website[] Websites { get; set; }
    }

    public class Website
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}