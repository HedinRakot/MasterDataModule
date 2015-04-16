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
            connection = new HubConnection(siteUrl);
            myHub = connection.CreateHubProxy(hubName);
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
        public async void SendNotification(CheckModuleType type, int infoId, int? checkStatus)
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

                await myHub.Invoke("StatusChanged", type, infoId, checkStatus);
            }
            catch
            {
            }
        }
    }
}
