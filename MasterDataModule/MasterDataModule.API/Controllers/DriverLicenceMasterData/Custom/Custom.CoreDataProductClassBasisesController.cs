using TuevSued.V1.IT.FE.MasterDataModule.API.Models.DriverLicenceMasterData;
using TuevSued.V1.IT.FE.MasterDataModule.API.Security;
using TuevSued.V1.IT.FE.MasterDataModule.API.SystemLog;
using System.Linq;
using System;
using System.Linq.Dynamic;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers.DriverLicenceMasterData
{
    public partial class CoreDataProductClassBasisesController
    {
        protected override IQueryable<CoreDataProductClassBasis> Sort(IQueryable<CoreDataProductClassBasis> entities, Sorting sorting)
        {
            if (sorting.Field == "examClassId")
                return entities.OrderBy("ExamClass.Name " + sorting.Direction);

            if (sorting.Field == "legalBasisId")
                return entities.OrderBy("LegalBasis.Name " + sorting.Direction);

            return base.Sort(entities, sorting);
        }
    }
}