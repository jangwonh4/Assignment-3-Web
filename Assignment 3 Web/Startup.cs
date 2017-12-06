using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment_3_Web.Startup))]
namespace Assignment_3_Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
