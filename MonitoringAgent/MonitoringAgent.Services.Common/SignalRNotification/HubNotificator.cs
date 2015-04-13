using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client;
using MonitoringAgent.Data.Interfaces.Enums;

namespace MonitoringAgent.Services.Common.SignalRNotification
{
    public class HubNotificator
    {
        private bool already = false;
        public void SendNotification(CheckModuleType type, int result, string message, string name)
        {
            if (already)
                return;
            already = true;

            var connection = new HubConnection("http://localhost:49991/");
            var myHub = connection.CreateHubProxy("monitorableObjects");

            connection.Start().Wait(); // not sure if you need this if you are simply posting to the hub

            myHub.Invoke("StatusChanged", type, result, message, name); 
        }
    }
}
