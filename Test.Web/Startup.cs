using Custom.Identity.Data;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test.Web.Startup))]
namespace Test.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Application_Startup.ConfigureAuth(app);
        }
    }
}
