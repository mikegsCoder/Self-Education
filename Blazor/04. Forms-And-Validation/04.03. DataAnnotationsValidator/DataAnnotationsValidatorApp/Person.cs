using System.ComponentModel.DataAnnotations;

namespace DataAnnotationsValidatorApp
{
    public class Person
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Name must be between {2} and {1} characters long")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(1, 110, ErrorMessage = "Age must be between {2} and {1}")]
        public int Age { get; set; }
    }
}
