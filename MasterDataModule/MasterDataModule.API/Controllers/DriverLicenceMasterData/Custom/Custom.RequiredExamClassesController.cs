using TuevSued.V1.IT.FE.MasterDataModule.API.Models.DriverLicenceMasterData;
using TuevSued.V1.IT.FE.MasterDataModule.API.Security;
using TuevSued.V1.IT.FE.MasterDataModule.API.SystemLog;
using System.Linq;
using System;
using System.Linq.Dynamic;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers.DriverLicenceMasterData
{
    public partial class RequiredExamClassesController
    {
        protected override IQueryable<ExamClassRequiredClass> Sort(IQueryable<ExamClassRequiredClass> entities, Sorting sorting)
        {
            if (sorting.Field == "requiredExamClassId")
                return entities.OrderBy("ExamCLASS1.Name " + sorting.Direction);

            return base.Sort(entities, sorting);
        }
    }
}