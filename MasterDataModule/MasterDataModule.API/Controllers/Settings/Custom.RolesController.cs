using System.Linq;
using MasterDataModule.API.Models.Settings;
using MasterDataModule.Contracts.Entities.Configuration;
using MasterDataModule.Contracts.Managers.Configuration;

namespace MasterDataModule.API.Controllers.Settings
{
    //[AuthorizeByPermissions(PermissionTypes = new[] {PermissionTypes.Roles})]
    public partial class RolesController
    {
        protected void ExtraEntityToModel(Role entity, RoleModel model)
        {
            model.permissions = entity.Permissions.Select(e => e.Id).ToList();
        }

        protected void ExtraModelToEntity(Role entity, RoleModel model, ActionTypes actionType)
        {
            Manager.SetPermissions(entity, model.permissions);
        }
    }
}