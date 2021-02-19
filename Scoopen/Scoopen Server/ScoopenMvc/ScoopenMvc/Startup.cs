using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScoopenMvc.Startup))]
namespace ScoopenMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
