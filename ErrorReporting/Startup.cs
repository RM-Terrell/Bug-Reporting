using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ErrorReporting.Startup))]
namespace ErrorReporting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
