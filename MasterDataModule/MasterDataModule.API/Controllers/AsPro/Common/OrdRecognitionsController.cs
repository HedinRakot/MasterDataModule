using MasterDataModule.API.Models;
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
            model.orgAccountingAreaId = entity.OrgAccountingAreaId;
        }
        protected override void ModelToEntity(OrdRecognitionModel model, OrdRecognition entity, ActionTypes actionType)
        {
            entity.OrdRecognitionTypeId = model.ordRecognitionTypeId;
            entity.OrgAccountingAreaId = model.orgAccountingAreaId;
        }
    }
}
