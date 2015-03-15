using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System.Collections.Generic;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Custom Controller for <see cref="InsUnitCode"/> entity
    /// </summary>
    public partial class InsUnitCodesController
    {
        protected override string BuildWhereClause<T>(Filter filter)
        {
            if (filter.Field == "name")
            {
                var clauses = new List<string>();

                clauses.AddRange(new[] { 
        				base.BuildWhereClause<T>(new Filter { Field = "UnitCode", Operator = filter.Operator, Value = filter.Value }),
        				base.BuildWhereClause<T>(new Filter { Field = "Description", Operator = filter.Operator, 
                            Value = filter.Value }),
        			});

                return string.Join(" or ", clauses);
            }

            return base.BuildWhereClause<T>(filter);
        }
    }
}
