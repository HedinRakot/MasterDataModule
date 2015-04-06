using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Services.Common.Base;
using MonitoringAgent.Services.Common.Contracts;

namespace MonitoringAgent.WcfServices.Interfaces.Services
{
    /// <summary>
    /// Ping WCF service
    /// </summary>
    public interface IWcfPingService: IBasePingServiceWithLastResult<MasterDataWcfInfo, MasterDataWcfCheckResults>
    {
    }
}