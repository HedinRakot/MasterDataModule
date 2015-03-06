using System.Web.Http;
using TuevSued.V1.IT.FE.MasterDataModule.API.Models.DriverLicenceMasterData;
using TuevSued.V1.IT.FE.MasterDataModule.API.Security;
using TuevSued.V1.IT.FE.MasterDataModule.API.SystemLog;
using System.Linq;
using System;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.DriverLicenceMasterData;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers.DriverLicenceMasterData
{
    //[AuthorizeByPermissions(PermissionTypes = new[] { PermissionTypes.ReturnReasons })]
    public partial class ReturnReasonsController : ClientApiController<ReturnReasonModel, ReturnReason, int, IReturnReasonManager>
    {
        public ReturnReasonsController(IReturnReasonManager returnReasonManager)
            : base(returnReasonManager)
        {
        }

        protected override void EntityToModel(ReturnReason entity, ReturnReasonModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
            model.text1 = entity.Text1;
            model.text2 = entity.Text2;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
        }

        protected override void ModelToEntity(ReturnReasonModel model, ReturnReason entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = string.IsNullOrWhiteSpace(model.description) ? string.Empty : model.description;
            entity.Text1 = string.IsNullOrWhiteSpace(model.text1) ? string.Empty : model.text1;
            entity.Text1 = string.IsNullOrWhiteSpace(model.text2) ? string.Empty : model.text2;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}