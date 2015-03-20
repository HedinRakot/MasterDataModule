using MasterDataModule.API.Models;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="DriverSchool"/> entity
    /// </summary>
    public partial class DriverSchoolsController: ClientApiController<DriverSchoolModel, DriverSchool, int, IDriverSchoolManager>
    {

        public DriverSchoolsController(IDriverSchoolManager manager): base(manager){}

        protected override void EntityToModel(DriverSchool entity, DriverSchoolModel model)
        {
            model.driverSchoolNumber = entity.DriverSchoolNumber;
            model.ordCustomerId = entity.OrdCustomerId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(DriverSchoolModel model, DriverSchool entity, ActionTypes actionType)
        {
            entity.DriverSchoolNumber = model.driverSchoolNumber;
            entity.OrdCustomerId = model.ordCustomerId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
