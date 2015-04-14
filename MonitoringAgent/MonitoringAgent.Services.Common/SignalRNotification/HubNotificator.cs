using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client;
using MonitoringAgent.Data.Interfaces.Enums;

namespace MonitoringAgent.Services.Common.SignalRNotification
{
    /// <summary>
    /// Notified hub about checking
    /// </summary>
    public sealed class HubNotificator
    {
        private readonly IHubProxy myHub;
        private readonly HubConnection connection;
        private readonly object connectionSyncObject = new object();

        /// <summary>
        /// Ctor
        /// </summary>
        public HubNotificator(string siteUrl, string hubName)
        {
            connection = new HubConnection(siteUrl);//new HubConnection("http://localhost:49991/");
            myHub = connection.CreateHubProxy(hubName); //connection.CreateHubProxy("monitorableObjects");
        }

        /// <summary>
        /// Initialize connection to hub
        /// </summary>
        public async void Initialize()
        {
            try
            {
                await TryStart();
            }
            catch
            {
            }
        }

        private Task TryStart()
        {
            return connection.Start();
        }
        /// <summary>
        /// Send notification about result of checking
        /// </summary>
        public async void SendNotification(CheckModuleType type, int result, string message, string name)
        {
            try
            {
                if (connection.State != ConnectionState.Connected || connection.State != ConnectionState.Connected)
                {
                    lock (connectionSyncObject)
                    {
                        if (connection.State != ConnectionState.Connected || connection.State != ConnectionState.Connected)
                        {
                            TryStart().Wait();
                        }
                    }
                }
                await myHub.Invoke("StatusChanged", string.Format("Name: {0}, Module: {1}, result: {2}, Message: {3} ", name, type, result, message));
            }
            catch
            {
            }
        }
    }
}
