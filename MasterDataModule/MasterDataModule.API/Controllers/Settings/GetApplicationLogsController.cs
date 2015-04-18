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
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.GetApplicationLogs })]
    /// <summary>
    ///     Controller for <see cref="GetApplicationLogs"/> entity
    /// </summary>
    public partial class GetApplicationLogsController: ClientApiController<GetApplicationLogsModel, GetApplicationLogs, int, IGetApplicationLogsManager>
    {

        public GetApplicationLogsController(IGetApplicationLogsManager manager): base(manager){}

        protected override void EntityToModel(GetApplicationLogs entity, GetApplicationLogsModel model)
        {
            model.logLevel = entity.LogLevel;
            model.messageDate = entity.MessageDate;
            model.message = entity.Message;
            model.fileName = entity.FileName;
            model.logTypeInfoId = entity.LogTypeInfoId;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(GetApplicationLogsModel model, GetApplicationLogs entity, ActionTypes actionType)
        {
            entity.LogLevel = model.logLevel;
            entity.MessageDate = model.messageDate;
            entity.Message = model.message;
            entity.FileName = model.fileName;
            entity.LogTypeInfoId = model.logTypeInfoId;
        }
    }
}
