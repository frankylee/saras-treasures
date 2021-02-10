using System;
using System.Linq;

namespace SarasTreasures.Models
{
    public interface IStoryRepository
    {
        // Retrieve 
        IQueryable<Story> Stories { get; }
        Story GetStoryByTitle(string title);
        // Create
        void AddStory(Story story);
        // Update
        void UpdateStory(Story story);
    }
}
