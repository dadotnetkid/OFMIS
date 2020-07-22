using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web.Chat.Startup))]
namespace Web.Chat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
