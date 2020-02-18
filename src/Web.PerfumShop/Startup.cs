using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web.PerfumShop.Startup))]
namespace Web.PerfumShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
