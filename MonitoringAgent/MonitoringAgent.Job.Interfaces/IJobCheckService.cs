using System.Collections.Generic;
using MonitoringAgent.Data.Interfaces.Entities;

namespace MonitoringAgent.Job.Interfaces
{
    /// <summary>
    /// Service for checking jobs
    /// </summary>
    public interface IJobCheckService
    {
        /// <summary>
        /// Get all jobs for checking
        /// </summary>
        List<MasterDataJobInfo> GetAllJobContainersToCheck();
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