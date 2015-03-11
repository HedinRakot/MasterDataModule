using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="EmpOrgAssociationType"/> entity
    /// </summary>
    public partial class EmpOrgAssociationTypesController: ClientApiController<EmpOrgAssociationTypeModel, EmpOrgAssociationType, int, IEmpOrgAssociationTypeManager>
    {

        public EmpOrgAssociationTypesController(IEmpOrgAssociationTypeManager manager): base(manager){}

        protected override void EntityToModel(EmpOrgAssociationType entity, EmpOrgAssociationTypeModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
        }
        protected override void ModelToEntity(EmpOrgAssociationTypeModel model, EmpOrgAssociationType entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = model.description;
        }
    }
}
