using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Web.Http;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Custom Controller for <see cref="InsCoreDataProduct"/> entity
    /// </summary>
    public partial class InsCoreDataProductsController
    {
        protected override string BuildWhereClause<T>(Filter filter)
        {
            if (filter.Field == "name")
            {
                return String.Format("InsCoreDataProductLocalizations.Any(ProductName.Contains(\"{0}\") or Description.Contains(\"{0}\"))",
                    ToFormattedString(filter.Value));
            }
            return base.BuildWhereClause<T>(filter);
        }

        protected override IQueryable<InsCoreDataProduct> Sort(IQueryable<InsCoreDataProduct> entities, Sorting sorting)
        {
            if (sorting.Field == "productName")
                return entities.OrderBy("InsCoreDataProductLocalizations.FirstOrDefault().ProductName " + sorting.Direction);

            if (sorting.Field == "productDescription")
                return entities.OrderBy("InsCoreDataProductLocalizations.FirstOrDefault().Description " + sorting.Direction);

            return base.Sort(entities, sorting);
        }

        protected void ExtraEntityToModel(InsCoreDataProduct entity, InsCoreDataProductModel model)
        {
            model.productName = entity.ProductName;
            model.productDescription = entity.ProductDescription;
        }
    }
}
