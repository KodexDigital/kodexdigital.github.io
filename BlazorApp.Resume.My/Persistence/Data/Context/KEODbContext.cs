using Microsoft.EntityFrameworkCore;
using System;

namespace BlazorApp.Resume.My.Persistence.Data.Context
{
    public class KEODbContext : DbContext
    {
        public KEODbContext(DbContextOptions<KEODbContext> options):base(options)
        {}
        public DbSet<ResumeLike> Likes { get; set; }
        public DbSet<AppUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var passwordHash = BCrypt.Net.BCrypt.HashPassword("@Kodex_v2");
            modelBuilder.Entity<AppUser>().HasData(new AppUser { Id = Guid.NewGuid(), UserName = "kodex", PasswordKey = passwordHash, LoginTime = DateTime.Now });
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    SeedDefaultUser(modelBuilder);
        //    SeedAdminRoles(modelBuilder);
        //    SeedUserRoles(modelBuilder);

        //    base.OnModelCreating(modelBuilder);
        //}


        //private void SeedDefaultUser(ModelBuilder builder)
        //{
        //    AppUser user = new AppUser()
        //    {
        //        Id = "b74ddd14-6340-4840-95c2-db12554843e5",
        //        UserName = "kodex",
        //        Email = "digitalkenth@gmail.com",
        //        LockoutEnabled = false,
        //        LoginTime = DateTime.Now
        //    };

        //    PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();
        //    user.PasswordHash = passwordHasher.HashPassword(user, "@Kodex_v2");

        //    builder.Entity<AppUser>().HasData(user);
        //    builder.Entity<AppUser>().HasKey(x => x.Id);
        //}

        //private void SeedAdminRoles(ModelBuilder builder)
        //{
        //    builder.Entity<IdentityRole>()
        //        .HasData( new IdentityRole() 
        //        { 
        //            Id = "fab4fac1-c546-41de-aebc-a14da6895711", 
        //            Name = "Admin", ConcurrencyStamp = "1", 
        //            NormalizedName = "Admin" 
        //        });
        //}

        //private void SeedUserRoles(ModelBuilder builder)
        //{
        //    builder.Entity<IdentityUserRole<string>>()
        //        .HasData( new IdentityUserRole<string>() 
        //        { 
        //            RoleId = "fab4fac1-c546-41de-aebc-a14da6895711",
        //            UserId = "b74ddd14-6340-4840-95c2-db12554843e5" 
        //        });
        //}
    }
}
