using MasterDataModule.API.Models.Monitor;
using MasterDataModule.Contracts.Entities.Monitor;
using MasterDataModule.Contracts.Managers.Monitor;

namespace MasterDataModule.API.Controllers.Monitor
{
    public class WinServiceMonitorController : ClientApiController<WinServiceStatusModel, WinServiceStatus, int, IWinServiceStatusInfoManager>
    {

        public WinServiceMonitorController(IWinServiceStatusInfoManager manager) : base(manager) { }

        protected override void EntityToModel(WinServiceStatus entity, WinServiceStatusModel model)
        {
            model.attempt = entity.Attempt;
            model.name = entity.Name;
            model.checkDate = entity.CheckDate;
            model.checkStatus = entity.CheckStatus;
            model.message = entity.Message;
            model.machineName = entity.MachineName;
            model.logTypeInfoId = entity.LogTypeInfoId;
            
            
        }
        protected override void ModelToEntity(WinServiceStatusModel model, WinServiceStatus entity, ActionTypes actionType)
        {
            entity.Attempt = model.attempt;
            entity.Name= model.name;
            entity.CheckDate = model.checkDate;
            entity.CheckStatus = model.checkStatus;
            entity.Message = model.message;
            entity.MachineName = model.machineName;
            entity.LogTypeInfoId = model.logTypeInfoId;
        }
    }
}
