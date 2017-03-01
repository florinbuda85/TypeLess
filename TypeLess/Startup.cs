using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TypeLess.Startup))]
namespace TypeLess
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
