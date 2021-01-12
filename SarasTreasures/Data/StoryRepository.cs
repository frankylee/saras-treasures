using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SarasTreasures.Models;

namespace SarasTreasures.Data
{
    public class StoryRepository : IStoryRepository
    {
        // instance variables
        private SarasTreasuresContext context;

        // constructor
        public StoryRepository(SarasTreasuresContext c)
        {
            context = c;
        }

        // interface methods
        public IQueryable<Story> Stories
        {
            get
            {   // Get all Story objects in the Stories(HappyTails) DBContext
                // and include the User object in each Story
                return context.Story.Include(story => story.User);
            }
        } 

        public void AddStory(Story story)
        {
            // store in database
            context.Story.Add(story);
            context.SaveChanges();
        }

        public Story GetStoryByTitle(string title)
        {
            // find and return the first story with a matching title
            Story story = context.Story.First(s => s.Title == title);
            return story;
        }
    }
}
