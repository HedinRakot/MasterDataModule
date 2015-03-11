using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="ExamRecognitionType"/> entity
    /// </summary>
    public partial class ExamRecognitionTypesController: ClientApiController<ExamRecognitionTypeModel, ExamRecognitionType, int, IExamRecognitionTypeManager>
    {

        public ExamRecognitionTypesController(IExamRecognitionTypeManager manager): base(manager){}

        protected override void EntityToModel(ExamRecognitionType entity, ExamRecognitionTypeModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
        }
        protected override void ModelToEntity(ExamRecognitionTypeModel model, ExamRecognitionType entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = model.description;
        }
    }
}
