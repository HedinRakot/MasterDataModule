using MasterDataModule.API.Models.Monitor;
using MasterDataModule.Contracts.Entities.Monitor;
using MasterDataModule.Contracts.Managers.Monitor;

namespace MasterDataModule.API.Controllers.Monitor
{
    public class ApplicationLogToShowController : ClientApiController<ApplicationLogToShowModel, ApplicationLogToShow, int, IApplicationLogToShowManager>
    {

        public ApplicationLogToShowController(IApplicationLogToShowManager manager) : base(manager) { }

        protected override void EntityToModel(ApplicationLogToShow entity, ApplicationLogToShowModel model)
        {
            model.logLevel = entity.LogLevel;
            model.fileName = entity.FileName;
            model.messageDate = entity.MessageDate;
            model.message = entity.Message;
            model.logTypeInfoId = entity.LogTypeInfoId;
            
            
        }
        protected override void ModelToEntity(ApplicationLogToShowModel model, ApplicationLogToShow entity, ActionTypes actionType)
        {
            entity.LogLevel = model.logLevel;
            entity.FileName= model.fileName;
            entity.MessageDate = model.messageDate;
            entity.Message = model.message;
            entity.LogTypeInfoId = model.logTypeInfoId;
        }
    }
}
