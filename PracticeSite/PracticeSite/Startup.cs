using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PracticeSite.Startup))]
namespace PracticeSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
