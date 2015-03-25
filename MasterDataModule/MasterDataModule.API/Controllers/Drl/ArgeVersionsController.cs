using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.ArgeVersion })]
    /// <summary>
    ///     Controller for <see cref="ArgeVersion"/> entity
    /// </summary>
    public partial class ArgeVersionsController: ClientApiController<ArgeVersionModel, ArgeVersion, int, IArgeVersionManager>
    {

        public ArgeVersionsController(IArgeVersionManager manager): base(manager){}

        protected override void EntityToModel(ArgeVersion entity, ArgeVersionModel model)
        {
            model.programmName = entity.ProgrammName;
            model.versionSystem = entity.VersionSystem;
            model.expirationDate = entity.ExpirationDate;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(ArgeVersionModel model, ArgeVersion entity, ActionTypes actionType)
        {
            entity.ProgrammName = model.programmName;
            entity.VersionSystem = model.versionSystem;
            entity.ExpirationDate = model.expirationDate;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
