using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StaycationDemo.Models;
using System.Reflection.Emit;

namespace StaycationDemo.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
       // private readonly ModelBuilder modelBuilder;

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> AppUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Suite> Suites { get; set; }
    }
}
