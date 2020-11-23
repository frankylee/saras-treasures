using System;
using System.Linq;
using SarasTreasures.Models;

namespace SarasTreasures.Repos
{
    public interface IStoryRepository
    {
        // Retrieve 
        IQueryable<Story> Stories { get; }
        Story GetStoryByTitle(string title);
        // Create
        void AddStory(Story story);
    }
}
