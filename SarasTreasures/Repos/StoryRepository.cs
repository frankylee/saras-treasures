using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SarasTreasures.Models;

namespace SarasTreasures.Repos
{
    public class StoryRepository : IStoryRepository
    {
        // instance variables
        private StoryContext context;

        // constructor
        public StoryRepository(StoryContext c)
        {
            context = c;
        }

        // interface methods
        public IQueryable<Story> Stories
        {
            get
            {   // Get all Story objects in the Stories(HappyTails) DBContext
                // and include the User object in each Story
                return context.HappyTails.Include(story => story.UserName);
            }
        } 

        public void AddStory(Story story)
        {
            // store in database
            context.HappyTails.Add(story);
            context.SaveChanges();
        }

        public Story GetStoryByTitle(string title)
        {
            // find and return the first story with a matching title
            Story story = context.HappyTails.First(s => s.Title == title);
            return story;
        }
    }
}
