using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LocationServicesWebService.Startup))]
namespace LocationServicesWebService
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
