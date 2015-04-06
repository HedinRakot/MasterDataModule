using System.Collections.Generic;

namespace MonitoringAgent.Services.Common.Contracts
{
    /// <summary>
    /// Base interface for all services for monitor objects
    /// </summary>
    /// <typeparam name="TServiceInfo">Type of monitorable objects</typeparam>
    public interface IBasePingService<TServiceInfo>
    {
        /// <summary>
        /// Gets all objects for checking
        /// </summary>
        /// <returns></returns>
        List<TServiceInfo> GetAllInfos();
    }
}