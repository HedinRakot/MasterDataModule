using MasterDataModule.API.Models;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="OrgCostCenter"/> entity
    /// </summary>
    public partial class OrgCostCentersController: ClientApiController<OrgCostCenterModel, OrgCostCenter, int, IOrgCostCenterManager>
    {

        public OrgCostCentersController(IOrgCostCenterManager manager): base(manager){}

        protected override void EntityToModel(OrgCostCenter entity, OrgCostCenterModel model)
        {
            model.name = entity.Name;
            model.description = entity.Description;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(OrgCostCenterModel model, OrgCostCenter entity, ActionTypes actionType)
        {
            entity.Name = model.name;
            entity.Description = model.description;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
