using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_Authentication.Startup))]
namespace Project_Authentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
