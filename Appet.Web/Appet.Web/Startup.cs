using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Appet.Web.Startup))]
namespace Appet.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
