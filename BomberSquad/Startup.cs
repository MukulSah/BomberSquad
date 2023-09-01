using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BomberSquad.Startup))]
namespace BomberSquad
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
