using System;
using System.Linq;

namespace SarasTreasures.Models
{
    public interface IStoryRepository
    {
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
    }
}
