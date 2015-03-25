using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.InsObdStatus })]
    /// <summary>
    ///     Controller for <see cref="InsObdStatus"/> entity
    /// </summary>
    public partial class InsObdStatusesController: ClientApiController<InsObdStatusModel, InsObdStatus, int, IInsObdStatusManager>
    {

        public InsObdStatusesController(IInsObdStatusManager manager): base(manager){}

        protected override void EntityToModel(InsObdStatus entity, InsObdStatusModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
            model.auView = entity.AuView;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(InsObdStatusModel model, InsObdStatus entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = model.description;
            entity.AuView = model.auView;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
