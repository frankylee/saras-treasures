using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SarasTreasures.Models;

namespace SarasTreasures.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private UserManager<AppUser> userManager;
        private readonly IStoryRepository repo;

        public CommentController(UserManager<AppUser> userMngr, IStoryRepository r)
        {
            userManager = userMngr;
            repo = r;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Comment>> GetComments()
        {
            // Collect all comments from DB
            var comments = repo.Comments;
            // If no comments exist, return NotFound
            if (comments.Count() == 0)
                return NotFound();
            // Otherwise return Ok with the comments
            return Ok(comments);
        }

        // GET api/HappyTail/3
        [HttpGet("{id}")]
        public ActionResult<Comment> GetComment(int id)
        {
            // Find comment by id
            var comment = repo.GetCommentByID(id);
            // If comment is null, it does not exist
            if (comment == null)
                return NotFound();
            // Otherwise return the comment
            return comment;
        }


        [HttpPost]
        public async Task<ActionResult<Comment>> PostComment(Comment comment)
        {
            // If the comment is not empty, post to database
            if (comment != null)
            {
                // Add logged in user to the model
                comment.User = await userManager.GetUserAsync(User);
                // Add date and time of submission
                comment.Date = DateTime.Now;
                // Add comment to database
                repo.AddComment(comment);
                // Return OK
                return Ok(comment);
            }
            // Otherwise it's a BadRequest
            return BadRequest();
        }


        [HttpPut("{id}")]
        public ActionResult<Comment> PutComment(int id, Comment c)
        {
            // First get the comment with the same id
            var comment = repo.GetCommentByID(id);
            // If the id's match, update the comment with new values 
            if (id == comment.CommentID)
            {
                comment.Text = c.Text;
                // After updating values, update story in the database
                repo.UpdateComment(comment);
                // Return Ok
                return Ok(comment);
            }
            // Otherwise it's a BadRequest
            return BadRequest();
        }


        [HttpPatch("{id}")]
        public ActionResult<Comment> PatchComment(int id, string path, string value)
        {
            // First get the comment with the same id
            var comment = repo.GetCommentByID(id);
            // Update the new value
            switch (path)
            {
                case "text":
                    comment.Text = value;
                    break;
                default:
                    return BadRequest();
            }
            // Update the comment in the database
            repo.UpdateComment(comment);
            // Return OK
            return Ok(comment);
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteComment(int id)
        {
            // Get the comment with the same id
            var comment = repo.GetCommentByID(id);
            // If comment exists, remove from context
            if (comment != null)
            {
                repo.DeleteComment(id);
                return NoContent();  // Successfully completed, no data to send back
            }
            // Otherwise it's NotFound
            return NotFound();
        }
    }
}
