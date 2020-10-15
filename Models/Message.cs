using System;
namespace SarasTreasures.Models
{
    public class Message
    {
        // collect details from user to send a message to SARA
        // user does not need to login to use contact form
        public string SenderName { get; set; }
        public string Company { get; set; }
        public string SenderEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string MessageBody { get; set; }
    }
}
