using MasterDataModule.API.Models.Monitor;
using MasterDataModule.Contracts.Entities.Monitor;
using MasterDataModule.Contracts.Managers.Monitor;

namespace MasterDataModule.API.Controllers.Monitor
{
    public class MasterDataWcfInfoController : ClientApiController<MasterDataWcfInfoModel, MasterDataWcfInfo, int, IMasterDataWcfInfoManager>
    {

        public MasterDataWcfInfoController(IMasterDataWcfInfoManager manager) : base(manager) { }

        protected override void EntityToModel(MasterDataWcfInfo entity, MasterDataWcfInfoModel model)
        {
            model.name = entity.Name;
            model.timeoutChecking = entity.TimeoutChecking;
            model.wsdlPath = entity.WsdlPath;
            model.changeDate = entity.ChangeDate;

        }
        protected override void ModelToEntity(MasterDataWcfInfoModel model, MasterDataWcfInfo entity, ActionTypes actionType)
        {
            
            entity.Name= model.name;
            entity.TimeoutChecking = model.timeoutChecking;
            entity.WsdlPath = model.wsdlPath;
        }
    }
}
