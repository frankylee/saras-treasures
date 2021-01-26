using System;
using System.ComponentModel.DataAnnotations;

namespace SarasTreasures.Models
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Username must be 5-30 characters.")]
        [RegularExpression(@"^[a-zA-Z]+([a-zA-Z0-9]?[_\.]??)+[a-zA-Z0-9]+$",
            ErrorMessage = "Username may not contain special characters except underscores and periods.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "First name must be 1-50 characters.")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "First name may not contain special characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Last name must be 1-50 characters.")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Last name may not contain special characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter an email address.")]
        [StringLength(254, MinimumLength = 5, ErrorMessage = "Email address must be 5-254 characters.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
