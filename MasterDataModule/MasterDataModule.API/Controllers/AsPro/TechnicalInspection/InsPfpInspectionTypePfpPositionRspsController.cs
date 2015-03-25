using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.InsPfpInspectionTypePfpPositionRsp })]
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
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
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
