using System;
namespace SarasTreasures.Models
{
    public class Stories
    {
        // modeled after Happy Tails on SARA's Treasures
        public string StoryTitle { get; set; }
        public User UserName { get; set; }
        public string StoryText { get; set; }
        public DateTime adoptionDate { get; set; }
        public string FileName { get; set; }
    }
}
