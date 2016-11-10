using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_BNG.Startup))]
namespace MVC_BNG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
