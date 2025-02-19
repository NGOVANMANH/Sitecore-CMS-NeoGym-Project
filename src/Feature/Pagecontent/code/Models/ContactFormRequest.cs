using System.ComponentModel.DataAnnotations;

namespace MySite.Feature.PageContent.Models
{
    public class ContactFormRequest
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^\+?\d{10,15}$", ErrorMessage = "Invalid phone number format")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Message is required")]
        [StringLength(500, ErrorMessage = "Message cannot exceed 500 characters")]
        public string Message { get; set; }
    }
}
