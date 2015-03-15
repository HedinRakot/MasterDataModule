using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="OrdRecognitionAreaOfWorkRsp"/> entity
    /// </summary>
    public partial class OrdRecognitionAreaOfWorkRspsController: ClientApiController<OrdRecognitionAreaOfWorkRspModel, OrdRecognitionAreaOfWorkRsp, int, IOrdRecognitionAreaOfWorkRspManager>
    {

        public OrdRecognitionAreaOfWorkRspsController(IOrdRecognitionAreaOfWorkRspManager manager): base(manager){}

        protected override void EntityToModel(OrdRecognitionAreaOfWorkRsp entity, OrdRecognitionAreaOfWorkRspModel model)
        {
            model.ordRecognitionId = entity.OrdRecognitionId;
            model.ordAreaOfWorkId = entity.OrdAreaOfWorkId;
            model.priority = entity.Priority;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
        }
        protected override void ModelToEntity(OrdRecognitionAreaOfWorkRspModel model, OrdRecognitionAreaOfWorkRsp entity, ActionTypes actionType)
        {
            entity.OrdRecognitionId = model.ordRecognitionId;
            entity.OrdAreaOfWorkId = model.ordAreaOfWorkId;
            entity.Priority = model.priority;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
