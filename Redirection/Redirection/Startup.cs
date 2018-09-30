using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Redirection.Startup))]
namespace Redirection
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
