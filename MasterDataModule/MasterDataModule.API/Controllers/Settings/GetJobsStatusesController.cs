using MasterDataModule.API.Models;
using MasterDataModule.API.Models.Settings;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Contracts.Managers.Configuration;
using System;

namespace MasterDataModule.API.Controllers.Settings
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.GetJobsStatus })]
    /// <summary>
    ///     Controller for <see cref="GetJobsStatus"/> entity
    /// </summary>
    public partial class GetJobsStatusesController: ClientApiController<GetJobsStatusModel, GetJobsStatus, int, IGetJobsStatusManager>
    {

        public GetJobsStatusesController(IGetJobsStatusManager manager): base(manager){}

        protected override void EntityToModel(GetJobsStatus entity, GetJobsStatusModel model)
        {
            model.checkStatus = entity.CheckStatus;
            model.checkDate = entity.CheckDate;
            model.lastRunTime = entity.LastRunTime;
            model.name = entity.Name;
            model.jobName = entity.JobName;
            model.logTypeInfoId = entity.LogTypeInfoId;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(GetJobsStatusModel model, GetJobsStatus entity, ActionTypes actionType)
        {
            entity.CheckStatus = model.checkStatus;
            entity.CheckDate = model.checkDate;
            entity.LastRunTime = model.lastRunTime;
            entity.Name = model.name;
            entity.JobName = model.jobName;
            entity.LogTypeInfoId = model.logTypeInfoId;
        }
    }
}
