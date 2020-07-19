using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApiBlock.Startup))]
namespace ApiBlock
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
