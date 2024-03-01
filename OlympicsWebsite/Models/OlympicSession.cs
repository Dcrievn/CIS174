using Microsoft.AspNetCore.Http;
using System.Security.Cryptography;

namespace OlympicsWebsite.Models
{
    public class OlympicSession
    {
        private const string CountriesKey = "mycountries";
        private const string CountKey = "countrycount";
        private const string OlympicGameKey = "olympic";
        private const string SportTypeKey = "sport";

        private ISession session {  get; set; }
        public OlympicSession(ISession session)
        {
            this.session = session;
        }
        public void SetMyCountries(List<Country> countries) 
        {
            session.SetObject(CountriesKey, countries);
            session.SetInt32(CountKey, countries.Count);
        }
        public List<Country> GetMyCountries() => 
        session.GetObject<List<Country>>(CountriesKey) ?? new List<Country>();
        public int? GetMyCountryCount() => session.GetInt32(CountKey);
        public void SetActiveGame(string activeGame) =>
        session.SetString(OlympicGameKey, activeGame);
        public string GetActiveGame() => session.GetString(OlympicGameKey);
        public void SetActiveSport(string activeSport) =>
        session.SetString(SportTypeKey, activeSport);
        public string GetActiveSport() => session.GetString(SportTypeKey);
        public void RemoveMyCountry()
        {
            session.Remove(CountriesKey);
            session.Remove(CountKey);
        }
    }
}
