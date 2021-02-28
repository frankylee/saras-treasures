using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SarasTreasures.Models;

namespace SarasTreasures.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoryController : ControllerBase
    {
        private UserManager<AppUser> userManager;
        private readonly IStoryRepository repo;

        public StoryController(UserManager<AppUser> userMngr, IStoryRepository r)
        {
            userManager = userMngr;
            repo = r;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Story>> GetStories()
        {
            // Collect all stories from DB
            var stories = repo.Stories;
            // If no stories exist, return NotFound
            if (stories.Count() == 0)
                return NotFound();
            // Otherwise return Ok with the stories
            return Ok(stories);
        }

        // GET api/HappyTail/3
        [HttpGet("{id}")]
        public ActionResult<Story> GetStory(int id)
        {
            // Find storty by id
            var story = repo.GetStoryByID(id);
            // If story is null, it does not exist
            if (story == null)
                return NotFound();
            // Otherwise return the story
            return story;
        }


        [HttpPost]
        public async Task<ActionResult<Story>> PostStory(Story story)
        {
            // If the story is not empty, post to database
            if (story != null)
            {
                // Add logged in user to the model
                story.User = await userManager.GetUserAsync(User);
                // Add date and time of submission
                story.Date = DateTime.Now;
                // Add story to database
                repo.AddStory(story);
                // Return OK
                return Ok(story);
            }
            // Otherwise it's a BadRequest
            return BadRequest();
        }


        [HttpPut("{id}")]
        public ActionResult<Story> PutStory(int id, Story s)
        {
            // First get the story with the same id
            var story = repo.GetStoryByID(id);
            // If the id's match, update the story with new values 
            if (id == story.StoryID)
            {
                story.Title = s.Title;
                story.Text = s.Text;
                story.Filename = s.Filename;
                story.User = s.User;
                // After updating values, update story in the database
                repo.UpdateStory(story);
                // Return Ok
                return Ok(story);
            }
            // Otherwise it's a BadRequest
            return BadRequest();
        }


        //[HttpPatch("{id}")]
        //public ActionResult<Story> PatchStory(int id, string path, string value)
        //{
        //    // First get the story with the same id
        //    var story = repo.GetStoryByID(id);
        //    // Update the new value
        //    switch (path)
        //    {
        //        case "title":
        //            story.Title = value;
        //            break;
        //        case "text":
        //            story.Text = value;
        //            break;
        //        case "filename":
        //            story.Filename = value;
        //            break;
        //        default:
        //            return BadRequest();
        //    }
        //    // Update the story in the database
        //    repo.UpdateStory(story);
        //    // Return OK
        //    return Ok(story);
        //}


        [HttpDelete("{id}")]
        public IActionResult DeleteStory(int id)
        {
            // Get the story with the same id
            var story = repo.GetStoryByID(id);
            // If story exists, remove from context
            if (story != null)
            {
                repo.DeleteStory(id);
                return NoContent();  // Successfully completed, no data to send back
            }
            // Otherwise it's NotFound
            return NotFound();
        }

    }
}
