using MasterDataModule.API.Models;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="OrgRelationshipType"/> entity
    /// </summary>
    public partial class OrgRelationshipTypesController: ClientApiController<OrgRelationshipTypeModel, OrgRelationshipType, int, IOrgRelationshipTypeManager>
    {

        public OrgRelationshipTypesController(IOrgRelationshipTypeManager manager): base(manager){}

        protected override void EntityToModel(OrgRelationshipType entity, OrgRelationshipTypeModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(OrgRelationshipTypeModel model, OrgRelationshipType entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
