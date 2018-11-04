using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vishalwebapp.Startup))]
namespace vishalwebapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
