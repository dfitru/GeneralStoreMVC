using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GeneralStroeMVC.Startup))]
namespace GeneralStroeMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
