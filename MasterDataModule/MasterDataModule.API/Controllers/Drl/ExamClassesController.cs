using MasterDataModule.API.Models;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="ExamClass"/> entity
    /// </summary>
    public partial class ExamClassesController: ClientApiController<ExamClassModel, ExamClass, int, IExamClassManager>
    {

        public ExamClassesController(IExamClassManager manager): base(manager){}

        protected override void EntityToModel(ExamClass entity, ExamClassModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
            model.isMofa = entity.IsMofa;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.isFsClass = entity.IsFsClass;
            model.sortOrder = entity.SortOrder;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(ExamClassModel model, ExamClass entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = model.description;
            entity.IsMofa = model.isMofa;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
            entity.IsFsClass = model.isFsClass;
            entity.SortOrder = model.sortOrder;
        }
    }
}
