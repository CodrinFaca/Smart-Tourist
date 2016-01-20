using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartTourist.WebClient.Startup))]
namespace SmartTourist.WebClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
