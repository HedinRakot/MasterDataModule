using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Common;
using TuevSued.V1.IT.FE.Entities.MasterDataModule.Common;
using TuevSued.V1.IT.FE.MasterDataModule.API.Models.CommonMasterData;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers.CommonMasterData
{
    class OrgAccountingAreaController: ClientApiController<OrgAccountingAreaModel, OrgAccountingArea, int, IOrgAccountingAreaManager>
    {
        public OrgAccountingAreaController(IOrgAccountingAreaManager manager) : base(manager)
        {
        }

        protected override void EntityToModel(OrgAccountingArea entity, OrgAccountingAreaModel model)
        {
            model.AccountingArea = entity.AccountingArea;
            model.Id = entity.Id;
            model.DeleteDate = entity.DeleteDate;
        }

        protected override void ModelToEntity(OrgAccountingAreaModel model, OrgAccountingArea entity, ActionTypes actionType)
        {
            entity.AccountingArea = model.AccountingArea;
            entity.DeleteDate = model.DeleteDate;
            entity.Id = model.Id;
        }
    }
}
