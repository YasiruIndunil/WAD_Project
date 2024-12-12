using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheGalleryCafe.Startup))]
namespace TheGalleryCafe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
