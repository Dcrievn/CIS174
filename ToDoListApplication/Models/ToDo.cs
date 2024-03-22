using System.ComponentModel.DataAnnotations;

namespace ToDoListApplication.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        [StringLength(255, ErrorMessage = "Please limit your description 255 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter a due date.")]
        [Range(typeof(DateTime), "1/1/2000", "12/31/2099", ErrorMessage = "Due date must be between 1/1/2000 and 12/31/2099.")]
        public DateTime? DueDate { get; set; }

        [Required(ErrorMessage = "Please select a category.")]
        public string CategoryId { get; set; }
        public Category Category { get; set; }

        [Required(ErrorMessage = "Please select a status.")]
        public string StatusId { get; set; }
        public Status Status { get; set; }
        public bool Overdue => Status?.Name.ToLower() == "open" && DueDate < DateTime.Today;
    }
}
