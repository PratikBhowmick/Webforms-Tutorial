using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoGridView.Startup))]
namespace DemoGridView
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
