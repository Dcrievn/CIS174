using System.ComponentModel.DataAnnotations;

namespace OlympicsWebsite.Models
{
    public class OlympicGame
    {
        [Key]
        public string GameID { get; set; }
        public string Name { get; set; }
    }
}
