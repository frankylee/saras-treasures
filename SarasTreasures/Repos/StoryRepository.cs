using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SarasTreasures.Models;

namespace SarasTreasures.Repos
{
    public class StoryRepository : IStoryRepository
    {
        // class variables
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
            throw new NotImplementedException();
        }

        public Story GetStoryByTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}
