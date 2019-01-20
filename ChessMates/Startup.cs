using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChessMates.Startup))]
namespace ChessMates
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
