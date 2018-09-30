using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoFinal.Startup))]
namespace DemoFinal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
