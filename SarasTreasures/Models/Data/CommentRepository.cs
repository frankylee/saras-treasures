using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SarasTreasures.Models
{
    public class CommentRepository : ICommentRepository
    {
        private SarasTreasuresContext context;

        public CommentRepository(SarasTreasuresContext c)
        {
            context = c;
        }

        public IQueryable<Comment> Comments
        {
            get
            {
                return context.Comment.Include(comment => comment.User);
            }
        }
        public Comment GetCommentByID(int id)
        {
            // Find comment with the mathing id
            Comment c = context.Comment.Include(comment => comment.User)
                .First(comment => comment.CommentID == id);
            // Return comment (or null)
            return c;
        }

        public void AddComment(Comment comment)
        {
            // Add to database and save changes
            context.Comment.Add(comment);
            context.SaveChanges();
        }

        public void UpdateComment(Comment comment)
        {
            // Update comment and save changes
            context.Comment.Update(comment);
            context.SaveChanges();
        }

        public void DeleteComment(int id)
        {
            // Find comment with the matching id
            Comment comment = context.Comment.First(comment => comment.CommentID == id);
            // Remove from context and save changes
            context.Remove(comment);
            context.SaveChanges();
        }
    }
}
