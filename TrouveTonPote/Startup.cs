using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrouveTonPote.Startup))]
namespace TrouveTonPote
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
