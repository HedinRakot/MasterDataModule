using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities.Monitor;
using MasterDataModule.Contracts.Managers.Monitor;
using MasterDataModule.Lib.Managers.Base;

namespace MasterDataModule.Lib.Managers.Monitor
{

    public partial class WinServiceStatusInfoManager : EntityManager<WinServiceStatus, int>,
        IWinServiceStatusInfoManager
    {
        public WinServiceStatusInfoManager(IMasterDataConfigurationEntities context)
            : base(context)
        {

        }
    }
}
