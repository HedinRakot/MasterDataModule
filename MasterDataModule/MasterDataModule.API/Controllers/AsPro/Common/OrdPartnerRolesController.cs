using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="OrdPartnerRole"/> entity
    /// </summary>
    public partial class OrdPartnerRolesController: ClientApiController<OrdPartnerRoleModel, OrdPartnerRole, int, IOrdPartnerRoleManager>
    {

        public OrdPartnerRolesController(IOrdPartnerRoleManager manager): base(manager){}

        protected override void EntityToModel(OrdPartnerRole entity, OrdPartnerRoleModel model)
        {
            model.sapQualifier = entity.SapQualifier;
        }
        protected override void ModelToEntity(OrdPartnerRoleModel model, OrdPartnerRole entity, ActionTypes actionType)
        {
            entity.SapQualifier = model.sapQualifier;
        }
    }
}
