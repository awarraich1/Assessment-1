using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assessment_Website.Startup))]
namespace Assessment_Website
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
