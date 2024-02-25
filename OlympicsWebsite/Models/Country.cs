using System.ComponentModel.DataAnnotations;

namespace OlympicsWebsite.Models
{
    public class Country
    {
        [Key]
        public string CountryID { get; set; }
        public string Name {  get; set; }
        public OlympicGame Game { get; set; }
        public SportType Sport {  get; set; }
        public string CountryImage {  get; set; }
    }
}
