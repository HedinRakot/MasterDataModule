using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="OrgType"/> entity
    /// </summary>
    public partial class OrgTypesController: ClientApiController<OrgTypeModel, OrgType, int, IOrgTypeManager>
    {

        public OrgTypesController(IOrgTypeManager manager): base(manager){}

        protected override void EntityToModel(OrgType entity, OrgTypeModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
        }
        protected override void ModelToEntity(OrgTypeModel model, OrgType entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = model.description;
        }
    }
}
