using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCangular.Startup))]
namespace MVCangular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
