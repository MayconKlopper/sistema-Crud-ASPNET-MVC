using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaCRUD.Startup))]
namespace SistemaCRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
