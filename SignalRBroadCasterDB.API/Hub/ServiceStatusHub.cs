using Microsoft.AspNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Web.Http.Cors;
using Microsoft.AspNet.SignalR.Hubs;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace SignalRBroadCasterDB.API
{
    //[HubName("DataHub")]
    //public class ServiceStatusHub
    //{
    //    //private static IHubContext hubContext =
    //    //GlobalHost.ConnectionManager.GetHubContext<ServiceStatusHub>();

    //    //public static ConcurrentDictionary<string, string> Connections = new ConcurrentDictionary<string, string>();

    //    ////public static void GetStatus(string username,string message)
    //    ////{

    //    ////    string connectionToSendMessage;
    //    ////    Connections.TryGetValue(username, out connectionToSendMessage);

    //    ////    //hubContext.Clients.All.acknowledgeMessage(message);

    //    ////    if (!string.IsNullOrWhiteSpace(connectionToSendMessage))
    //    ////    {
    //    ////        hubContext.Clients.Client(connectionToSendMessage).acknowledgeMessage(message);
    //    ////    }
            

    //    ////}

    //    //public static void GetStatus(string id, string message)
    //    //{

    //    //    //string connectionToSendMessage;
    //    //    //Connections.TryGetValue(username, out connectionToSendMessage);

    //    //    //hubContext.Clients.All.acknowledgeMessage(message);

    //    //    if (!string.IsNullOrWhiteSpace(id))
    //    //    {
    //    //        hubContext.Clients.Client(id).acknowledgeMessage(message);
    //    //    }


    //    //}

    //    ////public void GetStatus(string username, string message)
    //    ////{
    //    ////    string connectionToSendMessage;
    //    ////    Connections.TryGetValue(username, out connectionToSendMessage);

    //    ////    if (!string.IsNullOrWhiteSpace(connectionToSendMessage))
    //    ////    {
    //    ////        hubContext.Clients(connectionToSendMessage).acknowledgeMessage(message);
    //    ////        Clients.Clients(connectionToSendMessage).acknowledgeMessage(message);
    //    ////    }
    //    ////}

    //    //public override Task OnConnected()
    //    //{
    //    //    //It works I get the UserName
    //    //    //var ID = Context.ConnectionId;

    //    //    //string UserName = Context.QueryString["username"];

    //    //    if (!Connections.ContainsKey(Context.ConnectionId) && !String.IsNullOrEmpty(Context.QueryString["username"]))
    //    //    {
    //    //        Connections.TryAdd(Context.QueryString["UserName"], Context.ConnectionId);
    //    //    }



    //    //    //Connections.TryAdd(Context.QueryString["username"], Context.ConnectionId);
    //    //    return base.OnConnected();
    //    //}
    //}
}

