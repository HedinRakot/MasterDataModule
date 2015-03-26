using System.Linq;
using MasterDataModule.API.Models.Settings;
using MasterDataModule.Contracts.Entities.Configuration;

namespace MasterDataModule.API.Controllers.Settings
{
    //[AuthorizeByPermissions(PermissionTypes = new[] {PermissionTypes.Roles})]
    public partial class RolesController
    {
        protected void ExtraEntityToModel(Role entity, RoleModel model)
        {
        }

        protected void ExtraModelToEntity(Role entity, RoleModel model, ActionTypes actionType)
        {
        }
    }
}