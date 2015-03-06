using TuevSued.V1.IT.FE.MasterDataModule.API.Models.Settings;
using TuevSued.V1.IT.FE.MasterDataModule.API.Security;
using TuevSued.V1.IT.FE.MasterDataModule.API.SystemLog;
using System;
using System.Web.Http;
using System.Linq;
using System.Linq.Dynamic;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Settings;
using TuevSued.V1.IT.FE.CoreBase;
using TuevSued.V1.IT.FE.CoreBase.Localization;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers.Settings
{
    [AuthorizeByPermissions(PermissionTypes = new[] { PermissionTypes.SysTables })]
    public class SysColumnsController : ClientApiWithoutDeleteController<SysColumnModel, SysColumn, int, ISysColumnManager>
    {
        public SysColumnsController(ISysColumnManager manager)
            : base(manager)
        {

        }

        public override IHttpActionResult Post(SysColumnModel model)
        {
            return NotFound();
        }

        protected override void ModelToEntity(SysColumnModel model, SysColumn entity, ActionTypes actionType)
        {
            entity.ReadOnly = model.ReadOnly;
        }

        protected override void EntityToModel(SysColumn entity, SysColumnModel model)
        {
            var description = StringHelper.GetTextForCurrentLocale(entity.Description,
                CultureManager.Current.CurrentCulture);

            model.description = String.Format("{0} ({1})", description, entity.Name);
            model.tableId = entity.SysTableId;
            model.ReadOnly = entity.ReadOnly;
        }

        protected override IQueryable<SysColumn> GetEntities()
        {
            return base.GetEntities().Where(o => !o.DeleteDate.HasValue &&
                !o.Name.Equals("ID", StringComparison.InvariantCultureIgnoreCase) &&
                !o.Name.Equals("CREATE_DATE", StringComparison.InvariantCultureIgnoreCase) &&
                !o.Name.Equals("CREATE_EMPLOYEE_ID", StringComparison.InvariantCultureIgnoreCase) &&
                !o.Name.Equals("CHANGE_DATE", StringComparison.InvariantCultureIgnoreCase) &&
                !o.Name.Equals("CHANGE_EMPLOYEE_ID", StringComparison.InvariantCultureIgnoreCase) &&
                !o.Name.Equals("OWNER_ORG_ID", StringComparison.InvariantCultureIgnoreCase) &&
                !o.Name.Equals("VISIBILITY_ORG_ID", StringComparison.InvariantCultureIgnoreCase) &&
                !o.Name.Equals("ROW_VERSION", StringComparison.InvariantCultureIgnoreCase) &&
                !o.Name.Equals("SOURCE", StringComparison.InvariantCultureIgnoreCase) &&
                !o.Name.Equals("DELETE_DATE", StringComparison.InvariantCultureIgnoreCase));
        }
    }
}