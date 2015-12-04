using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AZD_Company.Startup))]
namespace AZD_Company
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
