using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="EmpCashPermissionType"/> entity
    /// </summary>
    public partial class EmpCashPermissionTypesController: ClientApiController<EmpCashPermissionTypeModel, EmpCashPermissionType, int, IEmpCashPermissionTypeManager>
    {

        public EmpCashPermissionTypesController(IEmpCashPermissionTypeManager manager): base(manager){}

        protected override void EntityToModel(EmpCashPermissionType entity, EmpCashPermissionTypeModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
        }
        protected override void ModelToEntity(EmpCashPermissionTypeModel model, EmpCashPermissionType entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = model.description;
        }
    }
}
