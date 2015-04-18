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
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.GetSitesStatus })]
    /// <summary>
    ///     Controller for <see cref="GetSitesStatus"/> entity
    /// </summary>
    public partial class GetSitesStatusesController: ClientApiController<GetSitesStatusModel, GetSitesStatus, int, IGetSitesStatusManager>
    {

        public GetSitesStatusesController(IGetSitesStatusManager manager): base(manager){}

        protected override void EntityToModel(GetSitesStatus entity, GetSitesStatusModel model)
        {
            model.checkStatus = entity.CheckStatus;
            model.checkDate = entity.CheckDate;
            model.message = entity.Message;
            model.attempt = entity.Attempt;
            model.name = entity.Name;
            model.sitePath = entity.SitePath;
            model.logTypeInfoId = entity.LogTypeInfoId;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(GetSitesStatusModel model, GetSitesStatus entity, ActionTypes actionType)
        {
            entity.CheckStatus = model.checkStatus;
            entity.CheckDate = model.checkDate;
            entity.Message = model.message;
            entity.Attempt = model.attempt;
            entity.Name = model.name;
            entity.SitePath = model.sitePath;
            entity.LogTypeInfoId = model.logTypeInfoId;
        }
    }
}
