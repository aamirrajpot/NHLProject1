using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NHLProject.Startup))]
namespace NHLProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
