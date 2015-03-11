using System;
using System.Linq;
using System.Web.Http;
using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using TuevSued.V1.IT.FE.CoreBase;
using TuevSued.V1.IT.FE.CoreBase.Localization;

namespace MasterDataModule.API.Controllers.Settings
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
            entity.ReadOnly = model.readOnly;
        }

        protected override void EntityToModel(SysColumn entity, SysColumnModel model)
        {
            var description = StringHelper.GetTextForCurrentLocale(entity.Description,
                CultureManager.Current.CurrentCulture);

            model.description = String.Format("{0} ({1})", description, entity.Name);
            model.sysTableId = entity.SysTableId;
            model.readOnly = entity.ReadOnly;
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