using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(UsersStatus.Startup))]
namespace UsersStatus
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}