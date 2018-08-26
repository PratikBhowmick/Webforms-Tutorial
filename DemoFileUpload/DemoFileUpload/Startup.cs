using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoFileUpload.Startup))]
namespace DemoFileUpload
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
