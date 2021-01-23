using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace SarasTreasures.Models
{
    public class AppUser : IdentityUser
    {
        [NotMapped]
        public IList<string> RoleNames { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "First name must be 1-50 characters.")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "First name may not contain special characters.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Last name must be 1-50 characters.")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Last name may not contain special characters.")]
        public string LastName { get; set; }
    }
}
