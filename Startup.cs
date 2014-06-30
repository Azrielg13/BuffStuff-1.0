using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuffStuff.Startup))]
namespace BuffStuff
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
