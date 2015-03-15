using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="OrgInformation"/> entity
    /// </summary>
    public partial class OrgInformationController: ClientApiController<OrgInformationModel, OrgInformation, int, IOrgInformationManager>
    {

        public OrgInformationController(IOrgInformationManager manager): base(manager){}

        protected override void EntityToModel(OrgInformation entity, OrgInformationModel model)
        {
            model.name = entity.Name;
            model.value = entity.Value;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
        }
        protected override void ModelToEntity(OrgInformationModel model, OrgInformation entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Value = model.value;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
