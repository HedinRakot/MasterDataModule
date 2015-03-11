using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="OrdRecognitionType"/> entity
    /// </summary>
    public partial class OrdRecognitionTypesController: ClientApiController<OrdRecognitionTypeModel, OrdRecognitionType, int, IOrdRecognitionTypeManager>
    {

        public OrdRecognitionTypesController(IOrdRecognitionTypeManager manager): base(manager){}

        protected override void EntityToModel(OrdRecognitionType entity, OrdRecognitionTypeModel model)
        {
            model.name = entity.Name;
        }
        protected override void ModelToEntity(OrdRecognitionTypeModel model, OrdRecognitionType entity, ActionTypes actionType)
        {
            entity.Name = model.name;
        }
    }
}
