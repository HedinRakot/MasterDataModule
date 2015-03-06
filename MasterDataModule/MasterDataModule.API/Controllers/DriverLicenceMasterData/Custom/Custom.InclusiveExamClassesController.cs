using TuevSued.V1.IT.FE.MasterDataModule.API.Models.DriverLicenceMasterData;
using TuevSued.V1.IT.FE.MasterDataModule.API.Security;
using TuevSued.V1.IT.FE.MasterDataModule.API.SystemLog;
using System.Linq;
using System;
using System.Linq.Dynamic;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers.DriverLicenceMasterData
{
    public partial class InclusiveExamClassesController
    {
        protected override IQueryable<ExamClassInclusiveClass> Sort(IQueryable<ExamClassInclusiveClass> entities, Sorting sorting)
        {
            if (sorting.Field == "inclusiveExamClassId")
                return entities.OrderBy("ExamCLASS1.Name " + sorting.Direction);

            return base.Sort(entities, sorting);
        }
    }
}