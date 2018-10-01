using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DOCTING.Startup))]
namespace DOCTING
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
