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
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.MasterDataJobCheckResults })]
    /// <summary>
    ///     Controller for <see cref="MasterDataJobCheckResults"/> entity
    /// </summary>
    public partial class MasterDataJobCheckResultsController: ClientApiController<MasterDataJobCheckResultsModel, MasterDataJobCheckResults, int, IMasterDataJobCheckResultsManager>
    {

        public MasterDataJobCheckResultsController(IMasterDataJobCheckResultsManager manager): base(manager){}

        protected override void EntityToModel(MasterDataJobCheckResults entity, MasterDataJobCheckResultsModel model)
        {
            model.lastRunTime = entity.LastRunTime;
            model.checkDate = entity.CheckDate;
            model.checkStatus = entity.CheckStatus;
            model.masterDataJobInfoId = entity.MasterDataJobInfoId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(MasterDataJobCheckResultsModel model, MasterDataJobCheckResults entity, ActionTypes actionType)
        {
            entity.LastRunTime = model.lastRunTime;
            entity.CheckDate = model.checkDate;
            entity.CheckStatus = model.checkStatus;
            entity.MasterDataJobInfoId = model.masterDataJobInfoId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
