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
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.GetWcfServicesStatus })]
    /// <summary>
    ///     Controller for <see cref="GetWcfServicesStatus"/> entity
    /// </summary>
    public partial class GetWcfServicesStatusesController: ClientApiController<GetWcfServicesStatusModel, GetWcfServicesStatus, int, IGetWcfServicesStatusManager>
    {

        public GetWcfServicesStatusesController(IGetWcfServicesStatusManager manager): base(manager){}

        protected override void EntityToModel(GetWcfServicesStatus entity, GetWcfServicesStatusModel model)
        {
            model.checkStatus = entity.CheckStatus;
            model.checkDate = entity.CheckDate;
            model.message = entity.Message;
            model.attempt = entity.Attempt;
            model.name = entity.Name;
            model.wsdlPath = entity.WsdlPath;
            model.logTypeInfoId = entity.LogTypeInfoId;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(GetWcfServicesStatusModel model, GetWcfServicesStatus entity, ActionTypes actionType)
        {
            entity.CheckStatus = model.checkStatus;
            entity.CheckDate = model.checkDate;
            entity.Message = model.message;
            entity.Attempt = model.attempt;
            entity.Name = model.name;
            entity.WsdlPath = model.wsdlPath;
            entity.LogTypeInfoId = model.logTypeInfoId;
        }
    }
}
