using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Koolouhui.Startup))]
namespace Koolouhui
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
