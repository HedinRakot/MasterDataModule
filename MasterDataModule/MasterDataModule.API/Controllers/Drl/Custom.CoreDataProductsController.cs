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
    ///     Custom Controller for <see cref="CoreDataProduct"/> entity
    /// </summary>
    public partial class CoreDataProductsController
    {
        protected override string BuildWhereClause<T>(Filter filter)
        {
            if (filter.Field == "name")
            {
                return String.Format("CoreDataProductLocalizations.Any(ProductName.Contains(\"{0}\") or Description.Contains(\"{0}\"))",
                    ToFormattedString(filter.Value));
            }
            return base.BuildWhereClause<T>(filter);
        }

        protected override IQueryable<CoreDataProduct> Sort(IQueryable<CoreDataProduct> entities, Sorting sorting)
        {
            if (sorting.Field == "name")
                return entities.OrderBy("CoreDataProductLocalizations.FirstOrDefault().ProductName " + sorting.Direction);

            if (sorting.Field == "description")
                return entities.OrderBy("CoreDataProductLocalizations.FirstOrDefault().Description " + sorting.Direction);

            return base.Sort(entities, sorting);
        }

        protected void ExtraEntityToModel(CoreDataProduct entity, CoreDataProductModel model)
        {
            model.productName = entity.ProductName;

            //var insCoreDataProductManager = (IInsCoreDataProductManager)GlobalConfiguration.Configuration.
            //    DependencyResolver.GetService(typeof(IInsCoreDataProductManager));
            //var insCoreDataProduct = insCoreDataProductManager.GetById(entity.InsCoreDataProductId);
            //if (insCoreDataProduct != null)
            //{
            //    model.insCoreDataProductName = insCoreDataProduct.ProductName;
            //}

            //TODO
            //if (entity.CoreDataProductLocalizations != null && entity.CoreDataProductLocalizations.Count != 0)
            //{
            //    model.description = entity.CoreDataProductLocalizations.FirstOrDefault().Description;
            //}
        }
    }
}
