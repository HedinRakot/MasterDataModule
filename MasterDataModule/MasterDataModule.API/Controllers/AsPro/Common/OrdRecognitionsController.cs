using MasterDataModule.API.Models;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="OrdRecognition"/> entity
    /// </summary>
    public partial class OrdRecognitionsController: ClientApiController<OrdRecognitionModel, OrdRecognition, int, IOrdRecognitionManager>
    {

        public OrdRecognitionsController(IOrdRecognitionManager manager): base(manager){}

        protected override void EntityToModel(OrdRecognition entity, OrdRecognitionModel model)
        {
            model.ordRecognitionTypeId = entity.OrdRecognitionTypeId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.orgAccountingAreaId = entity.OrgAccountingAreaId;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(OrdRecognitionModel model, OrdRecognition entity, ActionTypes actionType)
        {
            entity.OrdRecognitionTypeId = model.ordRecognitionTypeId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
            entity.OrgAccountingAreaId = model.orgAccountingAreaId;
        }
    }
}
