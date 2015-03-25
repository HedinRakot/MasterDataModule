using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.InsOpticalDefect })]
    /// <summary>
    ///     Controller for <see cref="InsOpticalDefect"/> entity
    /// </summary>
    public partial class InsOpticalDefectsController: ClientApiController<InsOpticalDefectModel, InsOpticalDefect, int, IInsOpticalDefectManager>
    {

        public InsOpticalDefectsController(IInsOpticalDefectManager manager): base(manager){}

        protected override void EntityToModel(InsOpticalDefect entity, InsOpticalDefectModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
            model.isCustom = entity.IsCustom;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(InsOpticalDefectModel model, InsOpticalDefect entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = model.description;
            entity.IsCustom = model.isCustom;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
