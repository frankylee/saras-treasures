using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SarasTreasures.Models
{
    public class SarasTreasuresContext : IdentityDbContext<AppUser>
    {
        public SarasTreasuresContext(DbContextOptions<SarasTreasuresContext> options) : base(options) { }

        // tables
        public DbSet<Story> Story { get; set; }
        public DbSet<Comment> Comment { get; set; }


        // seed data upon database creation
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<SarasTreasures.Models.AppUser>().HasData(
            //    new AppUser
            //    {
            //        UserName = "mrs.rosenblum",
            //        FirstName = "Sally",
            //        LastName = "Rosenblum",
            //        Email = "srosenblum@aol.com"
            //    },
            //    new AppUser
            //    {
            //        UserName = "paula_parrot",
            //        FirstName = "Paula",
            //        LastName = "Parrot",
            //        Email = "paula_parrot@yahoo.com"
            //    },
            //    new AppUser
            //    {
            //        UserName = "margotmerlot",
            //        FirstName = "Margot",
            //        LastName = "Merlot",
            //        Email = "winelover387@hotmail.com"
            //    }
            //);

            // Story: set primary key 
            //modelBuilder.Entity<Story>().HasKey(s => new { s.StoryID, s.User });

            // Story: set foreign keys 
            //modelBuilder.Entity<Story>().HasOne(s => s.StoryID)
            //    .WithMany(u => u.UserId)
            //    .HasForeignKey(s => s.UserId);
            //.OwnsOne(u => u.User)

            //modelBuilder.Entity<Story>().HasData(
            //    new Story
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
            //        Date = DateTime.Parse("11/1/2020"),
            //    },
            //    new Story
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
            //    },
            //    new Story
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
            //    }
            //);
        }

        public static async Task CreateAdminUser(IServiceProvider serviceProvider)
        {
            UserManager<AppUser> userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            List<string> roleNames = new List<string>() { "Admin", "User" };
            string username = "admin";
            string password = "Secret1!";
            //Dictionary<AppUser, string> users = new Dictionary<AppUser, string>(){
            //    {
            //        new AppUser {
            //            UserName = "admin",
            //            FirstName = "Sara",
            //            LastName = "Treasure",
            //            Email = "hello@sarastreasures.com"
            //        },
            //        "Secret1!"
            //    },
            //    {
            //        new AppUser {
            //            UserName = "mrs.rosenblum",
            //            FirstName = "Sally",
            //            LastName = "Rosenblum",
            //            Email = "srosenblum@aol.com",
            //            RoleNames = { "User" }
            //        },
            //        "Secret1!"
            //    },
            //    {
            //        new AppUser {
            //            UserName = "paula_parrot",
            //            FirstName = "Paula",
            //            LastName = "Parrot",
            //            Email = "paula_parrot@yahoo.com",
            //            RoleNames = { "User" }
            //        },
            //        "Secret1!"
            //    },
            //    {
            //        new AppUser {
            //            UserName = "margotmerlot",
            //            FirstName = "Margot",
            //            LastName = "Merlot",
            //            Email = "winelover387@hotmail.com",
            //            RoleNames = { "User" }
            //        },
            //        "Secret1!"
            //    },
            //};
           
            foreach (string roleName in roleNames)
            {
                // if role doesn't exist, create it
                if (await roleManager.FindByNameAsync(roleName) == null)
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            // if username doesn't exist, create it and add to role
            if (await userManager.FindByNameAsync(username) == null)
            {
                AppUser user = new AppUser {
                    UserName = "admin",
                    FirstName = "Sara",
                    LastName = "Treasure",
                    Email = "hello@sarastreasures.com"
                };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, roleNames[0]);
                }
            }
        }

    }
}
