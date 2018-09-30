using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo_DataTransfer.Startup))]
namespace Demo_DataTransfer
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
