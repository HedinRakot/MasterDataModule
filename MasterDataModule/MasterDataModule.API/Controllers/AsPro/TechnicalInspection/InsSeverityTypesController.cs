using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.InsSeverityType })]
    /// <summary>
    ///     Controller for <see cref="InsSeverityType"/> entity
    /// </summary>
    public partial class InsSeverityTypesController: ClientApiController<InsSeverityTypeModel, InsSeverityType, int, IInsSeverityTypeManager>
    {

        public InsSeverityTypesController(IInsSeverityTypeManager manager): base(manager){}

        protected override void EntityToModel(InsSeverityType entity, InsSeverityTypeModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(InsSeverityTypeModel model, InsSeverityType entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
