using System.Linq;
using MasterDataModule.API.Models.Settings;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;

namespace MasterDataModule.API.Controllers.Settings
{
    //[AuthorizeByPermissions(PermissionTypes = new[] {PermissionTypes.Roles})]
    public class RolesController : ClientApiController<RoleModel, Role, int, IRoleManager>
    {
        public RolesController(IRoleManager manager)
            : base(manager)
        {
        }

        protected override void EntityToModel(Role entity, RoleModel model)
        {
            model.name = entity.Name;
            model.permissions = entity.Permissions.Select(o => o.Id).ToList();
        }

        protected override void ModelToEntity(RoleModel model, Role entity, ActionTypes actionType)
        {
            entity.Name = model.name;

            Manager.SetPermissions(entity, model.permissions);
        }
    }
}