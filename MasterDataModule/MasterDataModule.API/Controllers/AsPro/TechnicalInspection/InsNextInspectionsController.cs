using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.InsNextInspection })]
    /// <summary>
    ///     Controller for <see cref="InsNextInspection"/> entity
    /// </summary>
    public partial class InsNextInspectionsController: ClientApiController<InsNextInspectionModel, InsNextInspection, int, IInsNextInspectionManager>
    {

        public InsNextInspectionsController(IInsNextInspectionManager manager): base(manager){}

        protected override void EntityToModel(InsNextInspection entity, InsNextInspectionModel model)
        {
            model.description = entity.Description;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(InsNextInspectionModel model, InsNextInspection entity, ActionTypes actionType)
        {
            entity.Description = model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
