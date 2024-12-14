using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TheGalleryCafe.Models
{
    // ApplicationUser represents a user in your system
    public class ApplicationUser : IdentityUser
    {
        // Add custom properties to the user if needed, for example:
        // public string FullName { get; set; }

        // Method to generate the user identity for authentication
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // The authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here, if needed
            return userIdentity;
        }
    }
    }

//    // ApplicationRole represents a role in your system
//    public class ApplicationRole : IdentityRole
//    {
//        // Roles don't need GenerateUserIdentityAsync method
//        // You can add additional properties if needed
//    }
//}
