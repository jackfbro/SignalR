using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Cors;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(SignalRChatService.Startup))]

namespace SignalRChatService
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=316888
            // Any connection or hub wire up and configuration should go here
            //string sqlConnectionString = @"Server=.;Database=SignalRChat;Integrated Security=True;";
            //GlobalHost.DependencyResolver.UseSqlServer(sqlConnectionString);          
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR();
        }
    }
}
