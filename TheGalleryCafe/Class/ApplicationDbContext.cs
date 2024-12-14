using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using TheGalleryCafe.Models; // Your models namespace

namespace TheGalleryCafe.Class
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> // Inherit from IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("DefaultConnection") { }

        // Add DbSet properties for your custom models
        public DbSet<TheGalleryCafe.Models.Table> Tables { get; set; }
        public DbSet<Promotion> Promotions { get; set; }

        // No need to redefine DbSet<IdentityRole> or DbSet<IdentityUserRole>
        // These are already available via IdentityDbContext<ApplicationUser>

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
