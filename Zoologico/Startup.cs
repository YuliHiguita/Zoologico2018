using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zoologico.Startup))]
namespace Zoologico
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
