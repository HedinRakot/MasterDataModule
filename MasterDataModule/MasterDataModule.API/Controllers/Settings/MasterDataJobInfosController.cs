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
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.MasterDataJobInfo })]
    /// <summary>
    ///     Controller for <see cref="MasterDataJobInfo"/> entity
    /// </summary>
    public partial class MasterDataJobInfosController: ClientApiController<MasterDataJobInfoModel, MasterDataJobInfo, int, IMasterDataJobInfoManager>
    {

        public MasterDataJobInfosController(IMasterDataJobInfoManager manager): base(manager){}

        protected override void EntityToModel(MasterDataJobInfo entity, MasterDataJobInfoModel model)
        {
            model.connectionString = entity.ConnectionString;
            model.tableName = entity.TableName;
            model.timeoutChecking = entity.TimeoutChecking;
            model.name = entity.Name;
            model.jobName = entity.JobName;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(MasterDataJobInfoModel model, MasterDataJobInfo entity, ActionTypes actionType)
        {
            entity.ConnectionString = model.connectionString;
            entity.TableName = model.tableName;
            entity.TimeoutChecking = model.timeoutChecking;
            entity.Name = model.name;
            entity.JobName = model.jobName;
        }
    }
}
