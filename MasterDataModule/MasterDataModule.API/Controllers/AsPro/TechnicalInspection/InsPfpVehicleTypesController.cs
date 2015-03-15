using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="InsPfpVehicleType"/> entity
    /// </summary>
    public partial class InsPfpVehicleTypesController: ClientApiController<InsPfpVehicleTypeModel, InsPfpVehicleType, int, IInsPfpVehicleTypeManager>
    {

        public InsPfpVehicleTypesController(IInsPfpVehicleTypeManager manager): base(manager){}

        protected override void EntityToModel(InsPfpVehicleType entity, InsPfpVehicleTypeModel model)
        {
            model.description = entity.Description;
            model.imageFileName = entity.ImageFileName;
            model.isPolygonDataValid = entity.IsPolygonDataValid;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
        }
        protected override void ModelToEntity(InsPfpVehicleTypeModel model, InsPfpVehicleType entity, ActionTypes actionType)
        {
            entity.Description = model.description;
            entity.ImageFileName = model.imageFileName;
            entity.IsPolygonDataValid = model.isPolygonDataValid;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
