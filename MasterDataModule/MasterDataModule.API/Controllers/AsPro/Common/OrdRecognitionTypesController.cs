using MasterDataModule.API.Models;
using MasterDataModule.API.Security;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Enums;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    [AuthorizeByPermissions(PermissionTypes = new[] { Permissions.OrdRecognitionType })]
    /// <summary>
    ///     Controller for <see cref="OrdRecognitionType"/> entity
    /// </summary>
    public partial class OrdRecognitionTypesController: ClientApiController<OrdRecognitionTypeModel, OrdRecognitionType, int, IOrdRecognitionTypeManager>
    {

        public OrdRecognitionTypesController(IOrdRecognitionTypeManager manager): base(manager){}

        protected override void EntityToModel(OrdRecognitionType entity, OrdRecognitionTypeModel model)
        {
            model.name = entity.Name;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(OrdRecognitionTypeModel model, OrdRecognitionType entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
