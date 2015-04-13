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
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.MasterDataSiteCheckResults })]
    /// <summary>
    ///     Controller for <see cref="MasterDataSiteCheckResults"/> entity
    /// </summary>
    public partial class MasterDataSiteCheckResultsController: ClientApiController<MasterDataSiteCheckResultsModel, MasterDataSiteCheckResults, int, IMasterDataSiteCheckResultsManager>
    {

        public MasterDataSiteCheckResultsController(IMasterDataSiteCheckResultsManager manager): base(manager){}

        protected override void EntityToModel(MasterDataSiteCheckResults entity, MasterDataSiteCheckResultsModel model)
        {
            model.checkStatus = entity.CheckStatus;
            model.checkDate = entity.CheckDate;
            model.message = entity.Message;
            model.attempt = entity.Attempt;
            model.masterDataSiteInfoId = entity.MasterDataSiteInfoId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(MasterDataSiteCheckResultsModel model, MasterDataSiteCheckResults entity, ActionTypes actionType)
        {
            entity.CheckStatus = model.checkStatus;
            entity.CheckDate = model.checkDate;
            entity.Message = model.message;
            entity.Attempt = model.attempt;
            entity.MasterDataSiteInfoId = model.masterDataSiteInfoId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
