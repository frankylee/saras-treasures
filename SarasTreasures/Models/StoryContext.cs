using System;
using Microsoft.EntityFrameworkCore;


namespace SarasTreasures.Models
{
    public class StoryContext : DbContext
    {
        public StoryContext(DbContextOptions<StoryContext> options) : base(options) { }

        // tables
        public DbSet<Story> HappyTails { get; set; }
        public DbSet<User> User { get; set; }
     }
}
