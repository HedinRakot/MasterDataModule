using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System.Collections.Generic;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Custom Controller for <see cref="OrgAccountingArea"/> entity
    /// </summary>
    public partial class OrgAccountingAreasController
    {
        protected override string BuildWhereClause<T>(Filter filter)
        {
            if (filter.Field == "name")
            {
                var clauses = new List<string>();

                clauses.AddRange(new[] { 
        				base.BuildWhereClause<T>(
                            new Filter { Field = "AccountingArea", Operator = filter.Operator, Value = filter.Value })
        			});

                return string.Join(" or ", clauses);
            }

            return base.BuildWhereClause<T>(filter);
        }
    }
}