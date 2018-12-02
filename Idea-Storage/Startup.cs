using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Idea_Storage.Startup))]
namespace Idea_Storage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
