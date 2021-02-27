using System;
using System.Linq;

namespace SarasTreasures.Models
{
    public interface IStoryRepository
    {
        // -----------
        //  S T O R Y
        // -----------

        // Create
        void AddStory(Story story);
        // Retrieve 
        IQueryable<Story> Stories { get; }
        Story GetStoryByID(int id);
        Story GetStoryByTitle(string title);
        // Update
        void UpdateStory(Story story);
        // Delete
        void DeleteStory(int id);

        // ---------------
        //  C O M M E N T
        // ---------------

        // Create
        void AddComment(Comment comment);
        // Retrieve 
        IQueryable<Comment> Comments { get; }
        Comment GetCommentByID(int id);
        // Update
        void UpdateComment(Comment comment);
        // Delete
        void DeleteComment(int id);
    }
}
