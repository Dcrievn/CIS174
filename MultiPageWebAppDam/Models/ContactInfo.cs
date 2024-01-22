using System.ComponentModel.DataAnnotations;

namespace MultiPageWebAppDam.Models
{
    public class ContactInfo
    {
        [Key]
        public int ContactID { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        // set as string to allow dashes between numbers if user chooses to do so
        [Required(ErrorMessage = "Please enter a phone number.")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; } 

        [Required(ErrorMessage = "Please enter an address.")]
        public string Address { get; set; }

        // note is set to nullable as I believe it isn't an important aspect when making new contacts
        public string? Note { get; set; }
        public string? Slug => Name?.Replace(' ', '-').ToLower();
    }
}
