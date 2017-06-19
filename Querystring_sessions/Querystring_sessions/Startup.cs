using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Querystring_sessions.Startup))]
namespace Querystring_sessions
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
