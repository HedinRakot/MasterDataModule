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
    public class SysTablesController : ClientApiWithoutDeleteController<SysTableModel, SysTable, int, ISysTableManager>
    {
        public SysTablesController(ISysTableManager manager)
            : base(manager)
        {

        }

        public override IHttpActionResult Post(SysTableModel model)
        {
            return NotFound();
        }

        protected override void ModelToEntity(SysTableModel model, SysTable entity, ActionTypes actionType)
        {
            entity.EditMode = (EditModeType)model.editMode;
        }

        protected override void EntityToModel(SysTable entity, SysTableModel model)
        {
            var description = StringHelper.GetTextForCurrentLocale(entity.Description,
                CultureManager.Current.CurrentCulture);

            model.description = String.Format("{0} ({1})", description, entity.Name);
            model.editMode = (int)entity.EditMode;
        }

        protected override IQueryable<SysTable> GetEntities()
        {
            return base.GetEntities().Where(o => !o.DeleteDate.HasValue);
        }
    }
}