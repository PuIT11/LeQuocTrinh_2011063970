using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeQuocTrinh_2011063970.Startup))]
namespace LeQuocTrinh_2011063970
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
