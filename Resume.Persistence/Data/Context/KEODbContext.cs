using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using System;

namespace Resume.Persistence.Data.Context
{
    public class KEODbContext : DbContext
    {
        public KEODbContext(DbContextOptions<KEODbContext> options):base(options)
        {}
        public DbSet<ResumeLike> Likes { get; set; }
        public DbSet<AppUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var passwordHash = BCrypt.Net.BCrypt.HashPassword("@Kodex");
            modelBuilder.Entity<AppUser>().HasData(new AppUser { Id = Guid.NewGuid(), Username = "kodex", PasswordKey = passwordHash, LoginTime = DateTime.Now });
        }
    }
}
