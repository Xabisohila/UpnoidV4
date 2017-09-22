using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UpnoidV4.Startup))]
namespace UpnoidV4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
