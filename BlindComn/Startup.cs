using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlindComn.Startup))]
namespace BlindComn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
