namespace OlympicsWebsite.Models
{
    public class CountryListViewModel : CountryViewModel
    {
        public List<Country> CountryList { get; set; }

        private List<OlympicGame> games;
        public List<OlympicGame> Games
        {
            get => games;
            set
            {
                games = value;
                games.Insert(0, new OlympicGame { GameID = "all", Name = "All" });
            }
        }
        private List<SportType> sports;
        public List<SportType> Sports
        {
            get => sports;
            set
            {
                sports = value;
                sports.Insert(0, new SportType { SportID = "all", Name = "All" });
            }
        }
        public string CheckActiveGame(string g) => g.ToLower() == ActiveGame.ToLower() ? "active" : "";

        public string CheckActiveSportType(string s) => s.ToLower() == ActiveSportType.ToLower() ? "active" : "";
    }
}
