using System;
using System.ComponentModel.DataAnnotations;

namespace SarasTreasures.Models
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }

        public string Text { get; set; }

        public DateTime Date { get; set; }

        public AppUser User { get; set; }
    }
}
