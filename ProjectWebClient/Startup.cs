using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectWebClient.Startup))]
namespace ProjectWebClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
