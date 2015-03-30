using System.Collections.Generic;
using MonitoringAgent.Data.Interfaces.Entities;

namespace MonitoringAgent.WcfServices.Interfaces.Services
{
    public interface IWcfPingService
    {
        List<WcfServiceInfo> GetAllServicesToCheck();
        void SetCheckingResults(List<WcfServiceInfo> serviceInfos);
    }
}