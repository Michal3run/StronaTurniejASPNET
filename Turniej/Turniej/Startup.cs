using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Turniej.Startup))]
namespace Turniej
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
