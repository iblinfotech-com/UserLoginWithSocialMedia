using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(External_Login_Identity.Startup))]
namespace External_Login_Identity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
