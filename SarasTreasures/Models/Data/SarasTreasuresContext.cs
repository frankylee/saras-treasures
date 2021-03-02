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
    }
}
