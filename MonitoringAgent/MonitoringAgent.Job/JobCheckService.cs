using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using MonitoringAgent.Data.Interfaces.Entities;
using MonitoringAgent.Data.Interfaces.Managers;
using MonitoringAgent.Job.Interfaces;
using MonitoringAgent.Services.Common.Base;
using MonitoringAgent.Services.Common.SqlServer;

namespace MonitoringAgent.Job
{
    public class JobCheckService: BaseManagersService, IJobCheckService
    {
        public JobCheckService(IManagersProvider managersProvider)
            : base(managersProvider)
        {
        }

        public List<MasterDataJobInfo> GetAllJobContainersToCheck()
        {
            var manager = ManagersProvider.GetManager<IMasterDataJobInfoManager>();
            return manager.GetAllEntities().ToList();
        }

        public MasterDataJobCheckResults CheckJob(MasterDataJobInfo jobInfo)
        {
            var scriptEngine = new ScriptEngine(jobInfo.ConnectionString);
            var result = scriptEngine.ExecuteQuery(string.Format("SELECT [LastLaunchTime] FROM {0} WHERE NAME = @JobName", jobInfo.TableName),
                new SqlParameter("@JobName", jobInfo.JobName));
            if (result != null && result.Rows.Count > 0)
            {
                var checkResult = new MasterDataJobCheckResults
                {
                    CheckStatus = 1,
                    CheckDate = DateTime.Now,
                    MasterDataJobInfoId = jobInfo.Id
                };
                if (!(result.Rows[0][0] is DBNull))
                {
                    checkResult.LastRunTime = Convert.ToDateTime(result.Rows[0][0]);
                }
                return checkResult;
            }
            return null;
        }


        public void SaveResults(MasterDataJobCheckResults result)
        {
            var manager = ManagersProvider.GetManager<IMasterDataJobCheckResultsManager>();
            var entity = manager.GetAllEntities().FirstOrDefault(e => e.MasterDataJobInfoId == result.MasterDataJobInfoId);
            if (entity != null)
            {
                entity.LastRunTime = result.LastRunTime;
                entity.CheckStatus = result.CheckStatus;
                entity.CheckDate = result.CheckDate;
            }
            else
            {
                entity = result;
            }

            manager.AddOrUpdateEntities(new[] { entity });
            manager.SaveChanges();
        }
    }
}
