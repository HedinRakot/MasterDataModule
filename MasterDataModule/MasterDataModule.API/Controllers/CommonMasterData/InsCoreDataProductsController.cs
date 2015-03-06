using TuevSued.V1.IT.FE.MasterDataModule.API.Models.CommonMasterData;
using TuevSued.V1.IT.FE.MasterDataModule.API.Security;
using TuevSued.V1.IT.FE.MasterDataModule.API.SystemLog;
using System.Linq;
using System;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.DriverLicenceMasterData;
using System.Collections.Generic;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.Common;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers.CommonMasterData
{
    //TODO [AuthorizeByPermissions(PermissionTypes = new[] { PermissionTypes.ExamClasses })]
    public partial class InsCoreDataProductsController : ReadOnlyClientApiController<InsCoreDataProductModel, InsCoreDataProduct, int, IInsCoreDataProductManager>
    {
        public InsCoreDataProductsController(IInsCoreDataProductManager insCoreDataProductManager)
            : base(insCoreDataProductManager)
        {
        }

        protected override void EntityToModel(InsCoreDataProduct entity, InsCoreDataProductModel model)
        {
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;

            model.name = entity.EntityTitle;

            //TODO
            if (entity.InsCoreDataProductLocalizations != null && entity.InsCoreDataProductLocalizations.Count != 0)
            {
                model.description = entity.InsCoreDataProductLocalizations.FirstOrDefault().Description;
            }

            model.productNumber = entity.ProductNumber;
        }
    }
}