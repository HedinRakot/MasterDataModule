using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="InsPfpPosition"/> entity
    /// </summary>
    public partial class InsPfpPositionsController: ClientApiController<InsPfpPositionModel, InsPfpPosition, int, IInsPfpPositionManager>
    {

        public InsPfpPositionsController(IInsPfpPositionManager manager): base(manager){}

        protected override void EntityToModel(InsPfpPosition entity, InsPfpPositionModel model)
        {
            model.text = entity.Text;
            model.topId = entity.TopId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
        }
        protected override void ModelToEntity(InsPfpPositionModel model, InsPfpPosition entity, ActionTypes actionType)
        {
            entity.Text = model.text;
            entity.TopId = model.topId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
