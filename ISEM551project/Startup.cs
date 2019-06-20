using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ISEM551project.Startup))]
namespace ISEM551project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
