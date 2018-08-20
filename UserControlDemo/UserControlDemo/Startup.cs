using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserControlDemo.Startup))]
namespace UserControlDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
