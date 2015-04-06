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
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.MasterDataWcfCheckResults })]
    /// <summary>
    ///     Controller for <see cref="MasterDataWcfCheckResults"/> entity
    /// </summary>
    public partial class MasterDataWcfCheckResultsController: ClientApiController<MasterDataWcfCheckResultsModel, MasterDataWcfCheckResults, int, IMasterDataWcfCheckResultsManager>
    {

        public MasterDataWcfCheckResultsController(IMasterDataWcfCheckResultsManager manager): base(manager){}

        protected override void EntityToModel(MasterDataWcfCheckResults entity, MasterDataWcfCheckResultsModel model)
        {
            model.checkStatus = entity.CheckStatus;
            model.checkDate = entity.CheckDate;
            model.message = entity.Message;
            model.attempt = entity.Attempt;
            model.masterDataWcfInfoId = entity.MasterDataWcfInfoId;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(MasterDataWcfCheckResultsModel model, MasterDataWcfCheckResults entity, ActionTypes actionType)
        {
            entity.CheckStatus = model.checkStatus;
            entity.CheckDate = model.checkDate;
            entity.Message = model.message;
            entity.Attempt = model.attempt;
            entity.MasterDataWcfInfoId = model.masterDataWcfInfoId;
        }
    }
}
