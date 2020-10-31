using System;
namespace SarasTreasures.Models
{
    public class Stories
    {
        // modeled after Happy Tails on SARA's Treasures
        public string Title { get; set; }
        public User UserName { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public string FileName { get; set; }
    }
}
