using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace MasterDataModule.API.SignalR
{
    [HubName("monitorableObjects")]
    public class MonitorableObjectsHub : Hub
    {
        public void StatusChanged(int checkModuleType, int infoId, int result)
        {
            Clients.All.statusChanged(checkModuleType, infoId, result);
        }
    }
}