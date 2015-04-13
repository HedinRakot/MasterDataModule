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
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.MasterDataWindowsServiceCheckResults })]
    /// <summary>
    ///     Controller for <see cref="MasterDataWindowsServiceCheckResults"/> entity
    /// </summary>
    public partial class MasterDataWindowsServiceCheckResultsController: ClientApiController<MasterDataWindowsServiceCheckResultsModel, MasterDataWindowsServiceCheckResults, int, IMasterDataWindowsServiceCheckResultsManager>
    {

        public MasterDataWindowsServiceCheckResultsController(IMasterDataWindowsServiceCheckResultsManager manager): base(manager){}

        protected override void EntityToModel(MasterDataWindowsServiceCheckResults entity, MasterDataWindowsServiceCheckResultsModel model)
        {
            model.checkStatus = entity.CheckStatus;
            model.checkDate = entity.CheckDate;
            model.message = entity.Message;
            model.attempt = entity.Attempt;
            model.masterDataWindowsServiceInfoId = entity.MasterDataWindowsServiceInfoId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(MasterDataWindowsServiceCheckResultsModel model, MasterDataWindowsServiceCheckResults entity, ActionTypes actionType)
        {
            entity.CheckStatus = model.checkStatus;
            entity.CheckDate = model.checkDate;
            entity.Message = model.message;
            entity.Attempt = model.attempt;
            entity.MasterDataWindowsServiceInfoId = model.masterDataWindowsServiceInfoId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
