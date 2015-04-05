using System.Collections.Generic;
using MonitoringAgent.Data.Interfaces.Entities;

namespace MonitoringAgent.WcfServices.Interfaces.Services
{
    /// <summary>
    /// Ping WCF service
    /// </summary>
    public interface IWcfPingService
    {
        /// <summary>
        /// Get all services for check
        /// </summary>
        /// <returns></returns>
        List<MasterDataWcfInfo> GetAllServicesToCheck();
        /// <summary>
        /// Saves checking result
        /// </summary>
        /// <param name="result">Result</param>
        void SetCheckingResult(MasterDataWcfCheckResults result);
        /// <summary>
        /// Gets last result
        /// </summary>
        /// <param name="serviceId">Service id</param>
        /// <returns></returns>
        MasterDataWcfCheckResults GetLastResult(int serviceId);
    }
}