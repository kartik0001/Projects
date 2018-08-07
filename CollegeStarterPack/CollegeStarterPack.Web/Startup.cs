using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CollegeStarterPack.Web.Startup))]
namespace CollegeStarterPack.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
