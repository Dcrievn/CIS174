using System.ComponentModel.DataAnnotations;

namespace OlympicsWebsite.Models
{
    public class SportType
    {
        [Key]
        public string SportID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
    }
}
