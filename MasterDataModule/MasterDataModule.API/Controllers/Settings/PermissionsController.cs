using System.Web.Http;
using MasterDataModule.API.Models.Settings;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;

namespace MasterDataModule.API.Controllers.Settings
{
    [AuthorizeByPermissions(PermissionTypes = new[] { PermissionTypes.Permissions })]
    public class PermissionsController : ClientApiWithoutDeleteController<PermissionModel, Permission, int, IPermissionManager>
    {
        public PermissionsController(IPermissionManager permissionManager): base(permissionManager)
        {

        }

        public override IHttpActionResult Post(PermissionModel model)
        {
            return NotFound();
        }

        protected override void EntityToModel(Permission entity, PermissionModel model)
        {
            model.name = entity.Name;
            model.systemName = entity.SystemName;
        }

        protected override void ModelToEntity(PermissionModel model, Permission entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.SystemName = model.systemName;
        }
    }
}