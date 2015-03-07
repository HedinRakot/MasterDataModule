using TuevSued.V1.IT.FE.MasterDataModule.API.Models.Settings;
using TuevSued.V1.IT.FE.MasterDataModule.API.Security;
using TuevSued.V1.IT.FE.MasterDataModule.API.SystemLog;
using System.Linq;
using System;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Settings;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers.Settings
{
	[AuthorizeByPermissions(PermissionTypes = new[] { PermissionTypes.Roles })]
	public class RolesController : ClientApiController<RoleModel, Role, int, IRoleManager>
	{
	    public RolesController(IRoleManager manager) : base(manager)
	    {
	    }

	    protected override void EntityToModel(Role entity, RoleModel model)
        {
            model.name = entity.Name;
            model.permissions = entity.Permissions.Select(o => o.Id).ToList();
            model.ChangeDate = entity.ChangeDate;
        }

        protected override void ModelToEntity(RoleModel model, Role entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            
            Manager.SetPermissions(entity, model.permissions);
        }
    }
}