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
        }

        public static async Task CreateAdminUser(IServiceProvider serviceProvider)
        {
            UserManager<AppUser> userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            List<string> roleNames = new List<string>() { "Admin", "User" };
            string password = "Secret1!";
            //List<AppUser> newUsers = new List<AppUser>()
            //{ 
            //    new AppUser {
            //        UserName = "mrs.rosenblum",
            //        FirstName = "Sally",
            //        LastName = "Rosenblum",
            //        Email = "srosenblum@aol.com",
            //    },
            //    new AppUser {
            //        UserName = "paula_parrot",
            //        FirstName = "Paula",
            //        LastName = "Parrot",
            //        Email = "paula_parrot@yahoo.com",
            //    },
            //    new AppUser {
            //        UserName = "margotmerlot",
            //        FirstName = "Margot",
            //        LastName = "Merlot",
            //        Email = "winelover387@hotmail.com",
            //    }
            //};

            foreach (string roleName in roleNames)
            {
                // if role doesn't exist, create it
                if (await roleManager.FindByNameAsync(roleName) == null)
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            // if admin doesn't exist, create it and add to role
            if (await userManager.FindByNameAsync("admin") == null)
            {
                AppUser admin = new AppUser
                {
                    UserName = "admin",
                    FirstName = "Sara",
                    LastName = "Treasure",
                    Email = "hello@sarastreasures.com"
                };
                var result = await userManager.CreateAsync(admin, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, roleNames[0]);
                }
            }

            // seed users to the database
            //foreach (AppUser user in newUsers)
            //{
            //    // if username doesn't exist, create it and add to role
            //    if (await userManager.FindByNameAsync(user.UserName) == null)
            //    {
            //        var result = await userManager.CreateAsync(user, password);
            //        if (result.Succeeded)
            //        {
            //            await userManager.AddToRoleAsync(user, roleNames[1]);
            //        }
            //    }
            //}
        }

    }
}
