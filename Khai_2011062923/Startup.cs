using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Khai_2011062923.Startup))]
namespace Khai_2011062923
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
