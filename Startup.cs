using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StreetKing.Startup))]
namespace StreetKing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
