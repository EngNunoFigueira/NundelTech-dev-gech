using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Getch_website.Startup))]
namespace Getch_website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
