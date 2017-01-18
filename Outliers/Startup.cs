using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Outliers.Startup))]
namespace Outliers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
