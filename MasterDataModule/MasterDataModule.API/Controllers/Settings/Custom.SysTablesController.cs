﻿using System;
using TuevSued.V1.IT.FE.CoreBase;
using TuevSued.V1.IT.FE.CoreBase.Localization;
using System.Collections.Generic;
using MasterDataModule.API.Models.Settings;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts.Entities.Configuration;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers.Configuration;
using System.Linq.Dynamic;
using System.Linq;

namespace MasterDataModule.API.Controllers.Settings
{
    public partial class SysTablesController
    {
        protected void ExtraEntityToModel(SysTable entity, SysTableModel model)
        {
            var description = StringHelper.GetTextForCurrentLocale(entity.Description,
                CultureManager.Current.CurrentCulture);
            model.tableDescription = String.Format("{0} ({1})", description, entity.Name);
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

        protected override IQueryable<SysTable> Sort(IQueryable<SysTable> entities, Sorting sorting)
        {
            if (sorting.Field == "tableDescription")
                return entities.OrderBy("Description " + sorting.Direction);
            
            return base.Sort(entities, sorting);
        }
    }
}