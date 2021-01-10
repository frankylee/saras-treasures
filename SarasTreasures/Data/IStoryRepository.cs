using System;
using System.Linq;
using SarasTreasures.Models;

namespace SarasTreasures.Data
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
