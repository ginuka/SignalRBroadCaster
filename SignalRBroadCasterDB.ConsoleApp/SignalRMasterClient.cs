using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBroadCasterDB.ConsoleApp
{
    public class SignalRMasterClient
    {
        public string Url { get; set; }
        public HubConnection Connection { get; set; }
        public IHubProxy Hub { get; set; }

        public SignalRMasterClient(string url)
        {

            var querystringData = new Dictionary<string, string>();
            querystringData.Add("username", "consoleApp");

            Url = url;
            Connection = new HubConnection(url, querystringData, useDefaultUrl: false);
            Hub = Connection.CreateHubProxy("DataHub");
            Connection.Start().Wait();
            

            Hub.On<string>("acknowledgeMessage", (message) =>
            {
                Console.WriteLine("Message received: " + message);

                /// TODO: Check status of the LDAP
                /// and update status to Web API.
            });
        }

        public void SayHello(string message)
        {
            Hub.Invoke("hello", message);
            Console.WriteLine("hello method is called!");
        }

        public void Stop()
        {
            Connection.Stop();
        }

    }
}
