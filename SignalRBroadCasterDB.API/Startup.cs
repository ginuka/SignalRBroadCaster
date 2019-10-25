using System;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Cors;


[assembly: OwinStartup(typeof(SignalRBroadCasterDB.API.Startup))]

namespace SignalRBroadCasterDB.API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            //app.MapSignalR("/signalr", new Microsoft.AspNet.SignalR.HubConfiguration());

            app.Map("/signalr", map =>
            {
                map.UseCors(CorsOptions.AllowAll);
                //map.UseCors(CorsOptions.AllowAll);
                var hubConfiguration = new HubConfiguration
                {
                    
                };
                map.RunSignalR(hubConfiguration);
            });
        }
    }
}
