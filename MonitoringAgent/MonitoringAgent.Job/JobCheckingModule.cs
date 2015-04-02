using System.Collections.Generic;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Services.Common.Base;

namespace MonitoringAgent.Job
{
    public class JobCheckingModule : CheckingModule<MasterDataJobInfo, MasterDataJobCheckResults>
    {
        private readonly JobCheckService jobCheckService;

        public JobCheckingModule(JobCheckService jobCheckService)
        {
            this.jobCheckService = jobCheckService;
        }

        protected override IList<MasterDataJobInfo> ServiceExtractor()
        {
            return jobCheckService.GetAllJobContainersToCheck();
        }

        protected override MasterDataJobCheckResults CheckService(MasterDataJobInfo serviceInfo)
        {
            return jobCheckService.CheckJob(serviceInfo);
        }

        protected override void SaveCheckingResult(MasterDataJobCheckResults result, MasterDataJobInfo info)
        {
            jobCheckService.SaveResults(result);
        }
    }
}
