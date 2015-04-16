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
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.WcfInfosWithLastResult })]
    /// <summary>
    ///     Controller for <see cref="WcfInfosWithLastResult"/> entity
    /// </summary>
    public partial class WcfInfosWithLastResultsController: ClientApiController<WcfInfosWithLastResultModel, WcfInfosWithLastResult, int, IWcfInfosWithLastResultManager>
    {

        public WcfInfosWithLastResultsController(IWcfInfosWithLastResultManager manager): base(manager){}

        protected override void EntityToModel(WcfInfosWithLastResult entity, WcfInfosWithLastResultModel model)
        {
            model.name = entity.Name;
            model.lastResult = entity.LastResult;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(WcfInfosWithLastResultModel model, WcfInfosWithLastResult entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.LastResult = model.lastResult;
        }
    }
}
