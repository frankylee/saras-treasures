using System;
namespace SarasTreasures.Models
{
    // View Model connects the Comment to the related Story
    public class CommentVM
    {
        public int CommentID { get; set; }

        public int StoryID { get; set; }

        public string Text { get; set; }
    }
}
