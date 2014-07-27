using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Koo.Web.Startup))]
namespace Koo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
