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
            model.productDescription = entity.ProductDescription;

            var insCoreDataProductManager = (IInsCoreDataProductManager)GlobalConfiguration.Configuration.
                DependencyResolver.GetService(typeof(IInsCoreDataProductManager));
            var insCoreDataProduct = insCoreDataProductManager.GetById(entity.InsCoreDataProductId);
            if (insCoreDataProduct != null)
            {
                model.insCoreDataProductName = insCoreDataProduct.ProductName;
                model.insCoreDataProductNumber = insCoreDataProduct.ProductNumber;
            }
        }

        protected void ExtraModelToEntity(CoreDataProduct entity, CoreDataProductModel model, ActionTypes actionType)
        {
            //if (actionType == ActionTypes.Add)
            //{
            //    var sysLanguageManager = (ISysLanguageManager)GlobalConfiguration.Configuration.
            //        DependencyResolver.GetService(typeof(ISysLanguageManager));

            //    var defaultLanguage = sysLanguageManager.GetEntities(o =>
            //        o.Description.Equals("Deutsch", StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();

            //    var defaultGermanlocalization = new CoreDataProductLocalization()
            //    {
            //        ProductName = model.name,
            //        SysLanguageId = defaultLanguage != null ? defaultLanguage.Id : 0,
            //        FromDate = model.fromDate,
            //        ToDate = model.toDate,
            //        Description = model.description,
            //        CoreDataProduct = entity
            //    };

            //    entity.CoreDataProductLocalizations = new List<CoreDataProductLocalization>();
            //    entity.CoreDataProductLocalizations.Add(defaultGermanlocalization);
            //}
        }
    }
}
