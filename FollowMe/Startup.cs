using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FollowMe.Startup))]
namespace FollowMe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
