using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities.Monitor;
using MasterDataModule.Contracts.Managers.Monitor;
using MasterDataModule.Lib.Managers.Base;

namespace MasterDataModule.Lib.Managers.Monitor
{

    public partial class WebSiteStatusInfoManager : EntityManager<WebSiteStatus, int>, IWebSiteStatusInfoManager
    {
        public WebSiteStatusInfoManager(IMasterDataConfigurationEntities context)
            : base(context)
        {
            
        }
    }
}
