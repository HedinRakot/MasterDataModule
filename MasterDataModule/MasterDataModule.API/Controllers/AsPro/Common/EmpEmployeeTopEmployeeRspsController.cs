using MasterDataModule.API.Models;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     Controller for <see cref="EmpEmployeeTopEmployeeRsp"/> entity
    /// </summary>
    public partial class EmpEmployeeTopEmployeeRspsController: ClientApiController<EmpEmployeeTopEmployeeRspModel, EmpEmployeeTopEmployeeRsp, int, IEmpEmployeeTopEmployeeRspManager>
    {

        public EmpEmployeeTopEmployeeRspsController(IEmpEmployeeTopEmployeeRspManager manager): base(manager){}

        protected override void EntityToModel(EmpEmployeeTopEmployeeRsp entity, EmpEmployeeTopEmployeeRspModel model)
        {
            model.empEmployeeId = entity.EmpEmployeeId;
            model.topEmployeeId = entity.TopEmployeeId;
            model.fromDate = entity.FromDate;
            model.toDate = entity.ToDate;
        }
        protected override void ModelToEntity(EmpEmployeeTopEmployeeRspModel model, EmpEmployeeTopEmployeeRsp entity, ActionTypes actionType)
        {
            entity.EmpEmployeeId = model.empEmployeeId;
            entity.TopEmployeeId = model.topEmployeeId;
            entity.FromDate = model.fromDate;
            entity.ToDate = model.toDate;
        }
    }
}
