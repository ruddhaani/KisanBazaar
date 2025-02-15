using KisanBazaar.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KisanBazaar.Data
{
    public class DataContext : IdentityDbContext<AppUser , AppRole , int , IdentityUserClaim<int> , AppUserRole , IdentityUserLogin<int> , IdentityRoleClaim<int> , IdentityUserToken<int>>
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }

        public DbSet<AppRole> Roles { get; set; }

        public DbSet<AppUserRole> UserRoles { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AppUser>()
                .HasKey(user => user.Id);

            modelBuilder.Entity<AppUser>()
                .HasMany(au => au.UserRoles)
                .WithOne(aur => aur.User)
                .HasForeignKey(aur => aur.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AppRole>()
                .HasMany(ar => ar.UserRoles)
                .WithOne(aur => aur.Role)
                .HasForeignKey(aur => aur.RoleId)
                .OnDelete(DeleteBehavior.Cascade);
            
        }
    }
}
