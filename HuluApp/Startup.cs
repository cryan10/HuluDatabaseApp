using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HuluApp.Startup))]
namespace HuluApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
