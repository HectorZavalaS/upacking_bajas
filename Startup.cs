using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(upacking_bajas.Startup))]
namespace upacking_bajas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
