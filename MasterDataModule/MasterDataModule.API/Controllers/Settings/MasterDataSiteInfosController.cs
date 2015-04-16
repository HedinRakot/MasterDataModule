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
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.MasterDataSiteInfo })]
    /// <summary>
    ///     Controller for <see cref="MasterDataSiteInfo"/> entity
    /// </summary>
    public partial class MasterDataSiteInfosController: ClientApiController<MasterDataSiteInfoModel, MasterDataSiteInfo, int, IMasterDataSiteInfoManager>
    {

        public MasterDataSiteInfosController(IMasterDataSiteInfoManager manager): base(manager){}

        protected override void EntityToModel(MasterDataSiteInfo entity, MasterDataSiteInfoModel model)
        {
            model.name = entity.Name;
            model.timeoutChecking = entity.TimeoutChecking;
            model.sitePath = entity.SitePath;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.logTypeInfoId = entity.LogTypeInfoId;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(MasterDataSiteInfoModel model, MasterDataSiteInfo entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.TimeoutChecking = model.timeoutChecking;
            entity.SitePath = model.sitePath;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
            entity.LogTypeInfoId = model.logTypeInfoId;
        }
    }
}
