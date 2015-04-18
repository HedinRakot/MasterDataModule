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
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.GetWinServicesStatus })]
    /// <summary>
    ///     Controller for <see cref="GetWinServicesStatus"/> entity
    /// </summary>
    public partial class GetWinServicesStatusesController: ClientApiController<GetWinServicesStatusModel, GetWinServicesStatus, int, IGetWinServicesStatusManager>
    {

        public GetWinServicesStatusesController(IGetWinServicesStatusManager manager): base(manager){}

        protected override void EntityToModel(GetWinServicesStatus entity, GetWinServicesStatusModel model)
        {
            model.checkStatus = entity.CheckStatus;
            model.checkDate = entity.CheckDate;
            model.message = entity.Message;
            model.attempt = entity.Attempt;
            model.name = entity.Name;
            model.machineName = entity.MachineName;
            model.logTypeInfoId = entity.LogTypeInfoId;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(GetWinServicesStatusModel model, GetWinServicesStatus entity, ActionTypes actionType)
        {
            entity.CheckStatus = model.checkStatus;
            entity.CheckDate = model.checkDate;
            entity.Message = model.message;
            entity.Attempt = model.attempt;
            entity.Name = model.name;
            entity.MachineName = model.machineName;
            entity.LogTypeInfoId = model.logTypeInfoId;
        }
    }
}
