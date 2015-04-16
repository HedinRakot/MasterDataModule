using MasterDataModule.API.Models.Monitor;
using MasterDataModule.Contracts.Entities.Monitor;
using MasterDataModule.Contracts.Managers.Monitor;

namespace MasterDataModule.API.Controllers.Monitor
{
    public class WebSiteMonitorController : ClientApiController<WebSiteStatusModel, WebSiteStatus, int, IWebSiteStatusInfoManager>
    {

        public WebSiteMonitorController(IWebSiteStatusInfoManager manager) : base(manager) { }

        protected override void EntityToModel(WebSiteStatus entity, WebSiteStatusModel model)
        {
            model.attempt = entity.Attempt;
            model.name = entity.Name;
            model.checkDate = entity.CheckDate;
            model.checkStatus = entity.CheckStatus;
            model.message = entity.Message;
            model.sitePath = entity.SitePath;
            model.logTypeInfoId = entity.LogTypeInfoId;
            
        }
        protected override void ModelToEntity(WebSiteStatusModel model, WebSiteStatus entity, ActionTypes actionType)
        {
            entity.Attempt = model.attempt;
            entity.Name= model.name;
            entity.CheckDate = model.checkDate;
            entity.CheckStatus = model.checkStatus;
            entity.Message = model.message;
            entity.SitePath = model.sitePath;
            entity.LogTypeInfoId = model.logTypeInfoId;
        }
    }
}
