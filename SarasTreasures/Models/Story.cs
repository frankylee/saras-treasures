using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SarasTreasures.Models
{
    public class Story
    {
        private List<Comment> comments = new List<Comment>();
        
        [Key]
        public int StoryID { get; set; }

        [Required(ErrorMessage = "Title field cannot be empty.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Title must be 3-60 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Story field cannot be empty.")]
        [StringLength(8000, MinimumLength = 10, ErrorMessage = "Story must be at least 10 characters.")]
        public string Text { get; set; }

        public string Filename { get; set; }

        public DateTime Date { get; set; }

        public AppUser User { get; set; }

        public List<Comment> Comments
        {
            get
            {
                return comments;
            }
        }
    }
}
