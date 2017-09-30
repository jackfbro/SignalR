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
            //SignalR Scaleout with Sql Server
            string sqlConnectionString = @"Server=.;Database=SignalRChat;uid=sa;pwd=123456;";
            GlobalHost.DependencyResolver.UseSqlServer(sqlConnectionString);
            //SignalR Scaleout with Redis
            //GlobalHost.DependencyResolver.UseRedis("server", port, "password", "AppName");
            app.UseCors(CorsOptions.AllowAll); //允许跨域请求
            app.MapSignalR();
        }
    }
}
