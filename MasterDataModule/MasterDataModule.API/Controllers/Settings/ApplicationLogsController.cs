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
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.ApplicationLogs })]
    /// <summary>
    ///     Controller for <see cref="ApplicationLogs"/> entity
    /// </summary>
    public partial class ApplicationLogsController: ClientApiController<ApplicationLogsModel, ApplicationLogs, int, IApplicationLogsManager>
    {

        public ApplicationLogsController(IApplicationLogsManager manager): base(manager){}

        protected override void EntityToModel(ApplicationLogs entity, ApplicationLogsModel model)
        {
            model.logType = entity.LogType;
            model.logLevel = entity.LogLevel;
            model.date = entity.Date;
            model.message = entity.Message;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(ApplicationLogsModel model, ApplicationLogs entity, ActionTypes actionType)
        {
            entity.LogType = model.logType;
            entity.LogLevel = model.logLevel;
            entity.Date = model.date;
            entity.Message = model.message;
        }
    }
}
