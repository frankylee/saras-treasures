using System;
using System.ComponentModel.DataAnnotations;

namespace SarasTreasures.Models
{
    public class ContactForm
    {
        // collect details from user to send a message to SARA
        // user does not need to login to use contact form

        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Name must be 1-50 characters.")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Name may not contain special characters.")]
        public string Name { get; set; }

        [RegularExpression(@"^[\w ]+$", ErrorMessage = "Company name may not contain special characters.")]
        public string Company { get; set; }

        [Required(ErrorMessage = "Please enter an email address.")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter a message.")]
        [StringLength(8000, MinimumLength = 10, ErrorMessage = "Message must be at least 10 characters.")]
        public string Message { get; set; }
    }
}
