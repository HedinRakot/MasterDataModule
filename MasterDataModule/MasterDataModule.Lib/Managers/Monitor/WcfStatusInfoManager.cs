using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities.Monitor;
using MasterDataModule.Contracts.Managers.Monitor;
using MasterDataModule.Lib.Managers.Base;

namespace MasterDataModule.Lib.Managers.Monitor
{

    public partial class WcfStatusInfoManager : EntityManager<WcfServiceStatus, int>, IWcfStatusInfoManager
    {

        public WcfStatusInfoManager(IMasterDataConfigurationEntities context) : base(context)
        {
            
        }



    }
}
