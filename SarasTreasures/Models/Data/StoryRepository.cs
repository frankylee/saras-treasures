﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SarasTreasures.Models
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
                // and include the User and Comment objects in each Story
                return context.Story.Include(story => story.User)
                    .Include(story => story.Comments)
                    .ThenInclude(comment => comment.User);
            }
        } 

        public void AddStory(Story story)
        {
            // store in database
            context.Story.Add(story);
            context.SaveChanges();
        }

        public void UpdateStory(Story story)
        {
            // update story in the database
            context.Story.Update(story);
            context.SaveChanges();
        }

        public Story GetStoryByID(int id)
        {
            // find and return the only story with the matching id
            Story story = context.Story.Include(story => story.User)
                .Include(story => story.Comments)
                .ThenInclude(comment => comment.User)
                .First(story => story.StoryID == id);
            return story;
        }

        public Story GetStoryByTitle(string title)
        {
            // find and return the first story with the matching title
            Story story = context.Story.First(s => s.Title == title);
            return story;
        }

        public IQueryable<Story> GetStoriesByUser(AppUser user)
        {
            return (from s in context.Story
                    where s.User.UserName.Equals(user)
                    select s).Include(s => s.User.UserName);
        }

        public void DeleteStory(int id)
        {
            // Find the story with a matching id
            Story story = context.Story.First(story => story.StoryID == id);
            // Remove story from context and save changes
            context.Remove(story);
            context.SaveChanges();
        }
    }
}

