using System;
using System.Linq;

namespace SarasTreasures.Models
{
    public interface ICommentRepository
    {
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
