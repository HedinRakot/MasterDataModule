using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Services.Common.Contracts;

namespace MonitoringAgent.Site.Interfaces.Services
{
    /// <summary>
    /// Service for working with sites
    /// </summary>
    public interface ISitePingServiceWithLastResult : IBasePingServiceWithLastResult<MasterDataSiteInfo, MasterDataSiteCheckResults>
    {
    }
}