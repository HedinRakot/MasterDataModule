using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="ExamStation"/> entity
    /// </summary>
    public partial class ExamStationsController: ClientApiController<ExamStationModel, ExamStation, int, IExamStationManager>
    {

        public ExamStationsController(IExamStationManager manager): base(manager){}

        protected override void EntityToModel(ExamStation entity, ExamStationModel model)
        {
            model.ordFederalStateId = entity.OrdFederalStateId;
            model.place = entity.Place;
            model.description = entity.Description;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.sortOrder = entity.SortOrder;
            model.createDate = entity.CreateDate;
            model.changeDate = entity.ChangeDate;
        }
        protected override void ModelToEntity(ExamStationModel model, ExamStation entity, ActionTypes actionType)
        {
            entity.OrdFederalStateId = model.ordFederalStateId;
            entity.Place = model.place;
            entity.Description = model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
            entity.SortOrder = model.sortOrder;
        }
    }
}
