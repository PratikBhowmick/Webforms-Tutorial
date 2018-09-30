using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FieldValidators.Startup))]
namespace FieldValidators
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
