using System.Collections.Generic;
using MonitoringAgent.Data.Interfaces.Entities;

namespace MonitoringAgent.Job.Interfaces
{
    public interface IJobCheckService
    {
        List<MasterDataJobInfo> GetAllJobContainersToCheck();
        MasterDataJobCheckResults CheckJob(MasterDataJobInfo jobInfo);
        void SaveResults(MasterDataJobCheckResults result);
    }
}