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
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.LogTypeInfo })]
    /// <summary>
    ///     Controller for <see cref="LogTypeInfo"/> entity
    /// </summary>
    public partial class LogTypeInfosController: ClientApiController<LogTypeInfoModel, LogTypeInfo, int, ILogTypeInfoManager>
    {

        public LogTypeInfosController(ILogTypeInfoManager manager): base(manager){}

        protected override void EntityToModel(LogTypeInfo entity, LogTypeInfoModel model)
        {
            model.fileName = entity.FileName;
            model.filePattern = entity.FilePattern;
            model.filePath = entity.FilePath;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(LogTypeInfoModel model, LogTypeInfo entity, ActionTypes actionType)
        {
            entity.FileName = model.fileName;
            entity.FilePattern = model.filePattern;
            entity.FilePath = model.filePath;
        }
    }
}
