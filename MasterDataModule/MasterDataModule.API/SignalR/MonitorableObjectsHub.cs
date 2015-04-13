using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace MasterDataModule.API.SignalR
{
    [HubName("monitorableObjects")]
    public class MonitorableObjectsHub: Hub
    {
        public void StatusChanged(string moduleType, int result, string message, string name)
        {

        }
    }
}
