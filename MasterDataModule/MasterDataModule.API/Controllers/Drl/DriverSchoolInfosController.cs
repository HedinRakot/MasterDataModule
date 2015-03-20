using MasterDataModule.API.Models;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="DriverSchoolInfo"/> entity
    /// </summary>
    public partial class DriverSchoolInfosController: ClientApiController<DriverSchoolInfoModel, DriverSchoolInfo, int, IDriverSchoolInfoManager>
    {

        public DriverSchoolInfosController(IDriverSchoolInfoManager manager): base(manager){}

        protected override void EntityToModel(DriverSchoolInfo entity, DriverSchoolInfoModel model)
        {
            model.schoolInfoId = entity.SchoolInfoId;
            model.driverSchoolId = entity.DriverSchoolId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
            model.createDate = ((ISystemFields)entity).CreateDate;
            model.changeDate = ((ISystemFields)entity).ChangeDate;
        }
        protected override void ModelToEntity(DriverSchoolInfoModel model, DriverSchoolInfo entity, ActionTypes actionType)
        {
            entity.SchoolInfoId = model.schoolInfoId;
            entity.DriverSchoolId = model.driverSchoolId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
