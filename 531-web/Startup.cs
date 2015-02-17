using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_531_web.Startup))]
namespace _531_web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
