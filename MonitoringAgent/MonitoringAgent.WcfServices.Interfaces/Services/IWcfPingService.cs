using System.Collections.Generic;
using MonitoringAgent.Data.Interfaces.Entities;

namespace MonitoringAgent.WcfServices.Interfaces.Services
{
    public interface IWcfPingService
    {
        List<MasterDataWcfInfo> GetAllServicesToCheck();
        void SetCheckingResult(MasterDataWcfCheckResults result);
        MasterDataWcfCheckResults GetLastResult(int serviceId);
    }
}