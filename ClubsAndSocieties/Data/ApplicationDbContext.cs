using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ClubsAndSocieties.Models;

namespace ClubsAndSocieties.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Administrator> Administrators { get; set; }

        public DbSet<Event> Events { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        //public DbSet<Club> Clubs { get; set; }
        //public DbSet<Student> Students { get; set; }
        //public DbSet<Administrator> Administrators { get; set; }

        //public DbSet<Event> Events { get; set; }
        //public DbSet<Member> Members { get; set; }
        //public DbSet<Notification> Notifications { get; set; }
        //public DbSet<Post> Posts { get; set; }
        
        public DbSet<ClubsAndSocieties.Models.Administrator> Administrator { get; set; }
    }
}
