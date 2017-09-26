using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DbTest.Startup))]
namespace DbTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
