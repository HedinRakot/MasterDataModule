using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="InsPfpInspectionTypePfpPositionRsp"/> entity
    /// </summary>
    public partial class InsPfpInspectionTypePfpPositionRspsController: ClientApiController<InsPfpInspectionTypePfpPositionRspModel, InsPfpInspectionTypePfpPositionRsp, int, IInsPfpInspectionTypePfpPositionRspManager>
    {

        public InsPfpInspectionTypePfpPositionRspsController(IInsPfpInspectionTypePfpPositionRspManager manager): base(manager){}

        protected override void EntityToModel(InsPfpInspectionTypePfpPositionRsp entity, InsPfpInspectionTypePfpPositionRspModel model)
        {
            model.insPfpPositionId = entity.InsPfpPositionId;
            model.insPfpInspectionTypeId = entity.InsPfpInspectionTypeId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
        }
        protected override void ModelToEntity(InsPfpInspectionTypePfpPositionRspModel model, InsPfpInspectionTypePfpPositionRsp entity, ActionTypes actionType)
        {
            entity.InsPfpPositionId = model.insPfpPositionId;
            entity.InsPfpInspectionTypeId = model.insPfpInspectionTypeId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
