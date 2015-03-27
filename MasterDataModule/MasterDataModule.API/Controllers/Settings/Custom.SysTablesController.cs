using System;
using System.Linq;
using System.Web.Http;
using MasterDataModule.API.Models;
using TuevSued.V1.IT.FE.CoreBase;
using TuevSued.V1.IT.FE.CoreBase.Localization;
using MasterDataModule.Contracts;
using System.Collections.Generic;
using MasterDataModule.API.Models.Settings;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts.Entities.Configuration;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers.Configuration;

namespace MasterDataModule.API.Controllers.Settings
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.ArgeVersion })]
    public partial class SysTablesController //: ClientApiWithoutDeleteController<SysTableModel, SysTable, int, ISysTableManager>
    {
        protected void ExtraEntityToModel(SysTable entity, SysTableModel model)
        {
            var description = StringHelper.GetTextForCurrentLocale(entity.Description,
                CultureManager.Current.CurrentCulture);
            model.tableDescription = String.Format("{0} ({1})", description, entity.Name);
        }

        //protected override IQueryable<SysTable> GetEntities()
        //{
        //    return base.GetEntities().Where(o => !o.DeleteDate.HasValue);
        //}

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