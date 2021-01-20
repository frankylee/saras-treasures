using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SarasTreasures.Models;

namespace SarasTreasures.Data
{
    public class SeedData
    {
        public static void Seed(SarasTreasuresContext context)
        {
            // populate data on startup (empty database only)
            //if (!context.Users.Any())
            //{
            //    User u = new User
            //    {
            //        UserName = "mrs.rosenblum",
            //        FirstName = "Sally",
            //        LastName = "Rosenblum",
            //        Email = "srosenblum@aol.com"
            //    };
            //    context.Users.Add(u);

            //    u = new User
            //    {
            //        UserName = "paula_parrot",
            //        FirstName = "Paula",
            //        LastName = "Parrot",
            //        Email = "paula_parrot@yahoo.com"
            //    };
            //    context.Users.Add(u);

            //    u = new User
            //    {
            //        UserName = "margotmerlot",
            //        FirstName = "Margot",
            //        LastName = "Merlot",
            //        Email = "winelover387@hotmail.com"
            //    };
            //    context.Users.Add(u);
            //    context.SaveChanges();
            //}

            //if (!context.Story.Any())
            //{
            //    Story story = new Story
            //    {
            //        StoryID = 1,
            //        Title = "Papaya",
            //        Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Vestibulum sed arcu non odio euismod lacinia. Sed vulputate odio ut enim. Sem et tortor consequat id porta nibh venenatis cras. Turpis egestas pretium aenean pharetra magna. Fusce id velit ut tortor. Sit amet consectetur adipiscing elit ut aliquam. Feugiat in fermentum posuere urna nec.

            //            Ut morbi tincidunt augue interdum velit euismod. Duis at consectetur lorem donec massa sapien faucibus. Nisl condimentum id venenatis a condimentum vitae. Justo eget magna fermentum iaculis. Tempus iaculis urna id volutpat. Et malesuada fames ac turpis egestas. Imperdiet massa tincidunt nunc pulvinar sapien et ligula ullamcorper.",
            //        User = new AppUser
            //        {
            //            UserName = "mrs.rosenblum",
            //            FirstName = "Sally",
            //            LastName = "Rosenblum",
            //            Email = "srosenblum@aol.com"
            //        },
            //        Filename = "zxyz.jpg",
            //        Date = DateTime.Parse("11/1/2020")
            //    };
            //    context.Story.Add(story);

            //    story = new Story
            //    {
            //        StoryID = 2,
            //        Title = "Little Bear",
            //        Text = @"Est ultricies integer quis auctor elit sed vulputate. Dolor morbi non arcu risus quis varius quam quisque. Vitae congue eu consequat ac felis. Ut consequat semper viverra nam libero justo. In tellus integer feugiat scelerisque varius morbi enim nunc. Bibendum enim facilisis gravida neque convallis a cras semper auctor. Neque convallis a cras semper. Risus sed vulputate odio ut enim blandit volutpat.

            //            Sagittis eu volutpat odio facilisis mauris sit amet. Quam vulputate dignissim suspendisse in est ante. Leo vel orci porta non pulvinar neque laoreet suspendisse. Auctor neque vitae tempus quam pellentesque nec. Risus nullam eget felis eget nunc lobortis mattis aliquam. Dignissim enim sit amet venenatis urna cursus eget nunc scelerisque.",
            //        User = new AppUser
            //        {
            //            UserName = "paula_parrot",
            //            FirstName = "Paula",
            //            LastName = "Parrot",
            //            Email = "paula_parrot@yahoo.com"
            //        },
            //        Filename = "zxyz.jpg",
            //        Date = DateTime.Parse("11/1/2020")
            //    };
            //    context.Story.Add(story);

            //    story = new Story
            //    {
            //        StoryID = 3,
            //        Title = "Big Bear",
            //        Text = @"Cras ornare arcu dui vivamus. Ultricies leo integer malesuada nunc vel risus commodo viverra. Mauris nunc congue nisi vitae. Donec ultrices tincidunt arcu non sodales neque sodales ut. Hac habitasse platea dictumst quisque sagittis purus. Donec ac odio tempor orci dapibus. Tellus orci ac auctor augue. Posuere lorem ipsum dolor sit. Lectus magna fringilla urna porttitor rhoncus dolor. Id velit ut tortor pretium viverra. Cursus eget nunc scelerisque viverra mauris in aliquam.

            //            Velit laoreet id donec ultrices tincidunt arcu non sodales neque. Egestas integer eget aliquet nibh praesent tristique magna sit amet. Cursus risus at ultrices mi tempus imperdiet nulla. Non enim praesent elementum facilisis leo vel fringilla est. At varius vel pharetra vel.",
            //        User = new AppUser
            //        {
            //            UserName = "margotmerlot",
            //            FirstName = "Margot",
            //            LastName = "Merlot",
            //            Email = "winelover387@hotmail.com"
            //        },
            //        Filename = "xyzyg.jpg",
            //        Date = DateTime.Parse("11/4/2020")
            //    };
            //    context.Story.Add(story);

            //    // save all the data
            //    context.SaveChanges();
            //}
        }
    }
}
