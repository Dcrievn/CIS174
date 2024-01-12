using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppDam.Models
{
    public class AgeModel
    {

        public DateTime today = DateTime.Now;

        [Required(ErrorMessage = "This field can not be empty")]
        [StringLength(20, ErrorMessage = "Name length can't be more than 20.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter a birth year")]
        [Range(1906, 2023, ErrorMessage = "Birth year must be between 1906 and 2023.")]
        /* range starts at 1906 as it is the birth year of the current oldest living person
         and ends at 2023 as age cannot be whole number if born in current year 2024 */
        public int? BirthYear { get; set; }
        public int? AgeThisYear()
        {
            int? age = today.Year - BirthYear;
            return age;
        }
    }
}
