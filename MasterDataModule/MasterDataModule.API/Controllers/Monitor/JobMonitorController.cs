using MasterDataModule.API.Models.Monitor;
using MasterDataModule.Contracts.Entities.Monitor;
using MasterDataModule.Contracts.Managers.Monitor;

namespace MasterDataModule.API.Controllers.Monitor
{
    public class JobMonitorController : ClientApiController<JobStatusModel,JobStatus, int, IJobStatusInfoManager>
    {

        public JobMonitorController(IJobStatusInfoManager manager) : base(manager) { }

        protected override void EntityToModel(JobStatus entity, JobStatusModel model)
        {
            model.jobName = entity.JobName;
            model.name = entity.Name;
            model.checkDate = entity.CheckDate;
            model.checkStatus = entity.CheckStatus;
            model.lastRunTime = entity.LastRunTime;
            model.logTypeInfoId = entity.LogTypeInfoId;
            
            
        }
        protected override void ModelToEntity(JobStatusModel model, JobStatus entity, ActionTypes actionType)
        {
            entity.JobName = model.jobName;
            entity.Name= model.name;
            entity.CheckDate = model.checkDate;
            entity.CheckStatus = model.checkStatus;
            entity.LastRunTime = model.lastRunTime;
            entity.LogTypeInfoId = model.logTypeInfoId;

        }
    }
}
