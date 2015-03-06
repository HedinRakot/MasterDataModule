using TuevSued.V1.IT.FE.MasterDataModule.API.Models.DriverLicenceMasterData;
using TuevSued.V1.IT.FE.MasterDataModule.API.Security;
using TuevSued.V1.IT.FE.MasterDataModule.API.SystemLog;
using System.Linq;
using System;
using System.Collections.Generic;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;
using System.Linq.Dynamic;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers.DriverLicenceMasterData
{
    public partial class CoreDataProductsController
    {
        protected override void Validate(CoreDataProductModel model, CoreDataProduct entity, ActionTypes actionType)
        {
        }

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
    }
}