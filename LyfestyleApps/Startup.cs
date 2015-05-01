using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LyfestyleApps.Startup))]
namespace LyfestyleApps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
