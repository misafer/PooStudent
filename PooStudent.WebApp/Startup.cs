using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PooStudent.WebApp.Startup))]
namespace PooStudent.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
