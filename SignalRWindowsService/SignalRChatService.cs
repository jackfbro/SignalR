using Microsoft.Owin;
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(SignalRChatService.Startup))]
namespace SignalRChatService
{
    public partial class SignalRChatService : ServiceBase
    {
        IDisposable SignalR;
        public SignalRChatService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {

            if (!System.Diagnostics.EventLog.SourceExists("SignalRChatService"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "SignalRChatService", "Application");
            }
            //eventLog1.Source = "SignalRChatService";
            //eventLog1.Log = "Application";

            //eventLog1.WriteEntry("In OnStart");
            string url = "http://localhost:8080";
            SignalR = WebApp.Start(url);

        }

        protected override void OnStop()
        {
            //eventLog1.WriteEntry("In OnStop");
            SignalR.Dispose();
        }
    }
}
