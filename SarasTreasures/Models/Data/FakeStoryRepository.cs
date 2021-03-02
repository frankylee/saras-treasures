using System;
using System.Collections.Generic;
using System.Linq;

namespace SarasTreasures.Models
{
    public class FakeStoryRepository : IStoryRepository
    {
        // instance variables
        private List<Story> stories = new List<Story>();


        // cast List object as IQueryable
        public IQueryable<Story> Stories { get { return stories.AsQueryable(); } }

        public IQueryable<Comment> Comments => throw new NotImplementedException();

        public void AddStory(Story story)
        {
            // simulate db primary key
            story.StoryID = stories.Count;
            stories.Add(story);
        }

        public void UpdateStory(Story story)
        {
            // simulate updating story in db
            throw new NotImplementedException();
        }

        public Story GetStoryByID(int id)
        {
            throw new NotImplementedException();
        }

        public Story GetStoryByTitle(string title)
        {
            // find and return the first story with a matching title
            Story story = stories.First(s => s.Title == title);
            return story;
        }

        public void DeleteStory(int id)
        {
            throw new NotImplementedException();
        }

        public void AddComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Comment GetCommentByID(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void DeleteComment(int id)
        {
            throw new NotImplementedException();
        }
    }
}
