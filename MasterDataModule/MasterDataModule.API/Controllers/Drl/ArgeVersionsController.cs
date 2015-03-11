using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
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
        }
        protected override void ModelToEntity(ArgeVersionModel model, ArgeVersion entity, ActionTypes actionType)
        {
            entity.ProgrammName = model.programmName;
            entity.VersionSystem = model.versionSystem;
            entity.ExpirationDate = model.expirationDate;
        }
    }
}
