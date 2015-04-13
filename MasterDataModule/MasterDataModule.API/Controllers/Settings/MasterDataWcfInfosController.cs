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
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.MasterDataWcfInfo })]
    /// <summary>
    ///     Controller for <see cref="MasterDataWcfInfo"/> entity
    /// </summary>
    public partial class MasterDataWcfInfosController: ClientApiController<MasterDataWcfInfoModel, MasterDataWcfInfo, int, IMasterDataWcfInfoManager>
    {

        public MasterDataWcfInfosController(IMasterDataWcfInfoManager manager): base(manager){}

        protected override void EntityToModel(MasterDataWcfInfo entity, MasterDataWcfInfoModel model)
        {
            model.name = entity.Name;
            model.wsdlPath = entity.WsdlPath;
            model.timeoutChecking = entity.TimeoutChecking;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(MasterDataWcfInfoModel model, MasterDataWcfInfo entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.WsdlPath = model.wsdlPath;
            entity.TimeoutChecking = model.timeoutChecking;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
