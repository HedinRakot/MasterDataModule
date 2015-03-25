using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.CoreDataProductClassBasis })]
    /// <summary>
    ///     Controller for <see cref="CoreDataProductClassBasis"/> entity
    /// </summary>
    public partial class CoreDataProductClassBasesController: ClientApiController<CoreDataProductClassBasisModel, CoreDataProductClassBasis, int, ICoreDataProductClassBasisManager>
    {

        public CoreDataProductClassBasesController(ICoreDataProductClassBasisManager manager): base(manager){}

        protected override void EntityToModel(CoreDataProductClassBasis entity, CoreDataProductClassBasisModel model)
        {
            model.examClassId = entity.ExamClassId;
            model.coreDataProductId = entity.CoreDataProductId;
            model.legalBasisId = entity.LegalBasisId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.sortOrder = entity.SortOrder;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(CoreDataProductClassBasisModel model, CoreDataProductClassBasis entity, ActionTypes actionType)
        {
            entity.ExamClassId = model.examClassId;
            entity.CoreDataProductId = model.coreDataProductId;
            entity.LegalBasisId = model.legalBasisId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
            entity.SortOrder = model.sortOrder;
        }
    }
}
