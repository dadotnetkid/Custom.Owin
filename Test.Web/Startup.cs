using Custom.Identity.Data;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Custom.Web.Startup))]
namespace Custom.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Application_Startup.ConfigureAuth(app);
        }
    }
}
