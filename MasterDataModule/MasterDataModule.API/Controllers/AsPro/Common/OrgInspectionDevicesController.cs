using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="OrgInspectionDevice"/> entity
    /// </summary>
    public partial class OrgInspectionDevicesController: ClientApiController<OrgInspectionDeviceModel, OrgInspectionDevice, int, IOrgInspectionDeviceManager>
    {

        public OrgInspectionDevicesController(IOrgInspectionDeviceManager manager): base(manager){}

        protected override void EntityToModel(OrgInspectionDevice entity, OrgInspectionDeviceModel model)
        {
            model.debitorCustomerNumber = entity.DebitorCustomerNumber;
            model.identification = entity.Identification;
            model.newIdentification = entity.NewIdentification;
            model.oldIdentification = entity.OldIdentification;
            model.type = entity.Type;
            model.serialNumber = entity.SerialNumber;
            model.name = entity.Name;
            model.description = entity.Description;
            model.lastInspectionDate = entity.LastInspectionDate;
            model.lastInspectionResult = entity.LastInspectionResult;
            model.inspectionDate = entity.InspectionDate;
            model.inspectionInterval = entity.InspectionInterval;
        }
        protected override void ModelToEntity(OrgInspectionDeviceModel model, OrgInspectionDevice entity, ActionTypes actionType)
        {
            entity.DebitorCustomerNumber = model.debitorCustomerNumber;
            entity.Identification = model.identification;
            entity.NewIdentification = model.newIdentification;
            entity.OldIdentification = model.oldIdentification;
            entity.Type = model.type;
            entity.SerialNumber = model.serialNumber;
            entity.Name = model.name;
            entity.Description = model.description;
            entity.LastInspectionDate = model.lastInspectionDate;
            entity.LastInspectionResult = model.lastInspectionResult;
            entity.InspectionDate = model.inspectionDate;
            entity.InspectionInterval = model.inspectionInterval;
        }
    }
}
