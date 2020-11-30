using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace SarasTreasures.Models
{
    public class SeedData
    {
        public static void Seed(StoryContext context)
        {
            if (!context.HappyTails.Any())
            {
                Story story = new Story
                {
                    Title = "Papaya",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    UserName = new User { Name = "Mrs. Rosenblum" },
                    FileName = "zxyz.jpg",
                    Date = DateTime.Parse("11/1/2020")
                };
                context.HappyTails.Add(story);

                story = new Story
                {
                    Title = "Little Bear",
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua ad minim veniam, quis nostrud exercitation ullamco laboris nisi.",
                    UserName = new User { Name = "Paula Parrot" },
                    FileName = "zxyz.jpg",
                    Date = DateTime.Parse("11/1/2020")
                };
                context.HappyTails.Add(story);

                story = new Story
                {
                    Title = "Big Bear",
                    Text = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in.",
                    UserName = new User { Name = "Margot Merlot" },
                    FileName = "xyzyg.jpg",
                    Date = DateTime.Parse("11/4/2020")
                };
                context.HappyTails.Add(story);

                // save all the data
                context.SaveChanges(); 
            }
        }
    }
}
