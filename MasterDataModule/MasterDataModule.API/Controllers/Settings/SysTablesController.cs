using System;
using System.Linq;
using System.Web.Http;
using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using TuevSued.V1.IT.FE.CoreBase;
using TuevSued.V1.IT.FE.CoreBase.Localization;
using MasterDataModule.Contracts;
using System.Collections.Generic;

namespace MasterDataModule.API.Controllers.Settings
{
    //[AuthorizeByPermissions(PermissionTypes = new[] {PermissionTypes.SysTables})]
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
            entity.EditMode = model.editMode;
        }

        protected override void EntityToModel(SysTable entity, SysTableModel model)
        {
            var description = StringHelper.GetTextForCurrentLocale(entity.Description,
                CultureManager.Current.CurrentCulture);

            model.description = String.Format("{0} ({1})", description, entity.Name);
            model.editMode = entity.EditMode;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }

        protected override IQueryable<SysTable> GetEntities()
        {
            return base.GetEntities().Where(o => !o.DeleteDate.HasValue);
        }

        protected override string BuildWhereClause<T>(Filter filter)
        {
            if (filter.Field == "name")
            {
                var clauses = new List<string>();

                clauses.AddRange(new[] { 
        				base.BuildWhereClause<T>(new Filter { Field = "Name", Operator = filter.Operator, Value = filter.Value }),
        				base.BuildWhereClause<T>(new Filter { Field = "Description", Operator = filter.Operator, 
                            Value = filter.Value }),
        			});

                return string.Join(" or ", clauses);
            }

            return base.BuildWhereClause<T>(filter);
        }
    }
}