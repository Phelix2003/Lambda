using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lambda.Startup))]
namespace Lambda
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
