namespace OlympicsWebsite.Models
{
    public class CountryViewModel
    {
        public Country Country { get; set; }
        public string ActiveGame { get; set; } = "all";
        public string ActiveSportType { get; set; } = "all";
    }
}
