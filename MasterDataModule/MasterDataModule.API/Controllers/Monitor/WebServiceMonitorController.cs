using MasterDataModule.API.Models.Monitor;
using MasterDataModule.Contracts.Entities.Monitor;
using MasterDataModule.Contracts.Managers.Monitor;

namespace MasterDataModule.API.Controllers.Monitor
{
    public class WebServiceMonitorController : ClientApiController<WcfServiceStatusModel, WcfServiceStatus, int, IWcfStatusInfoManager>
    {

        public WebServiceMonitorController(IWcfStatusInfoManager manager) : base(manager) { }

        protected override void EntityToModel(WcfServiceStatus entity, WcfServiceStatusModel model)
        {
            model.attempt = entity.Attempt;
            model.name = entity.Name;
            model.checkDate = entity.CheckDate;
            model.checkStatus = entity.CheckStatus;
            model.message = entity.Message;
            model.wsdlPath = entity.WsdlPath;
            model.logTypeInfoId = entity.LogTypeInfoId;
            
        }
        protected override void ModelToEntity(WcfServiceStatusModel model, WcfServiceStatus entity, ActionTypes actionType)
        {
            entity.Attempt = model.attempt;
            entity.Name= model.name;
            entity.CheckDate = model.checkDate;
            entity.CheckStatus = model.checkStatus;
            entity.Message = model.message;
            entity.WsdlPath = model.wsdlPath;
            entity.LogTypeInfoId = model.logTypeInfoId;
        }
    }
}
