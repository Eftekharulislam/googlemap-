using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Googlemap.Startup))]
namespace Googlemap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
