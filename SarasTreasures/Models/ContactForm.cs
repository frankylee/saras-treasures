using System;
namespace SarasTreasures.Models
{
    public class ContactForm
    {
        // collect details from user to send a message to SARA
        // user does not need to login to use contact form
        public string Name { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
    }
}
