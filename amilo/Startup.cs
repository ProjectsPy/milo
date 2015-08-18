using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(amilo.Startup))]
namespace amilo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
