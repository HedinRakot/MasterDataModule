using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Services.Common.Contracts;

namespace MonitoringAgent.Job.Interfaces
{
    /// <summary>
    /// Service for checking jobs
    /// </summary>
    public interface IJobCheckService : IBasePingService<MasterDataJobInfo>
    {
        /// <summary>
        /// Check job
        /// </summary>
        MasterDataJobCheckResults CheckJob(MasterDataJobInfo jobInfo);
        /// <summary>
        /// Saves cheking results
        /// </summary>
        void SaveResults(MasterDataJobCheckResults result);
    }
}