using System;
using Microsoft.EntityFrameworkCore;
namespace SarasTreasures.Models
{
    public class StoryContext : DbContext
    {
        public StoryContext(DbContextOptions<StoryContext> options) : base(options) { }

        public DbSet<Story> Rescue;

        public DbSet<User> User;
     }
}
