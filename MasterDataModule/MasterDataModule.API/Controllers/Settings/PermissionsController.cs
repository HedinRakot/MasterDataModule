using TuevSued.V1.IT.FE.MasterDataModule.API.Models.Settings;
using TuevSued.V1.IT.FE.MasterDataModule.API.Security;
using TuevSued.V1.IT.FE.MasterDataModule.API.SystemLog;
using System;
using System.Web.Http;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Settings;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers.Settings
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
            model.ChangeDate = entity.ChangeDate;
        }

        protected override void ModelToEntity(PermissionModel model, Permission entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.SystemName = model.systemName;
        }
    }
}