using Microsoft.Owin;
using Owin;
using TheGalleryCafe.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity.Owin;
using System;

[assembly: OwinStartupAttribute(typeof(TheGalleryCafe.Startup))]

namespace TheGalleryCafe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Configure the database context and user manager
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.CreatePerOwinContext<ApplicationSignInManager>(ApplicationSignInManager.Create);

            // Configure the cookie authentication middleware
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),  // Adjust as needed
                Provider = new CookieAuthenticationProvider
                {
                    // Allow external sign-in (like Google, Facebook, etc.), if you want
                    OnValidateIdentity = SecurityStampValidator.OnValidateIdentity<ApplicationUserManager, ApplicationUser>(
                        validateInterval: TimeSpan.FromMinutes(30),
                        regenerateIdentity: (manager, user) => user.GenerateUserIdentityAsync(manager))
                }
            });
        }
    }
}
