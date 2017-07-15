using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vip2Vip.Startup))]
namespace Vip2Vip
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
