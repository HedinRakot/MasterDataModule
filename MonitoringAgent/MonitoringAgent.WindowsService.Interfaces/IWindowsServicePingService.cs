using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Services.Common.Base;
using MonitoringAgent.Services.Common.Contracts;

namespace MonitoringAgent.WindowsService.Interfaces
{
    /// <summary>
    /// Service for working with Windows services
    /// </summary>
    public interface IWindowsServicePingService: IBasePingServiceWithLastResult<MasterDataWindowsServiceInfo, MasterDataWindowsServiceCheckResults>
    {
        /// <summary>
        /// Check windows service
        /// </summary>
        /// <param name="serviceInfo">Service info</param>
        /// <returns></returns>
        MasterDataWindowsServiceCheckResults CheckService(MasterDataWindowsServiceInfo serviceInfo);
    }
}
