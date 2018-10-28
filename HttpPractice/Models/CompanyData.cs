namespace HttpPractice.Models
{
    public class CompanyData
    {
        public string type { get; set; }

        public string id { get; set; }

        public CompanyAttributes attributes { get; set; }

        public Links links { get; set; }

    }
}