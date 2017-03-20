using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ERP.WebApi.Startup))]
namespace ERP.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
