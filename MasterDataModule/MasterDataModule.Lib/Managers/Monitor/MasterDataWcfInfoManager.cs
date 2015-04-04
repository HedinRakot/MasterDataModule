using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities.Monitor;
using MasterDataModule.Contracts.Managers.Monitor;
using MasterDataModule.Lib.Managers.Base;

namespace MasterDataModule.Lib.Managers.Monitor
{

    public partial class MasterDataWcfInfoManager : EntityManager<MasterDataWcfInfo, int>, IMasterDataWcfInfoManager
    {

        public MasterDataWcfInfoManager(IMasterDataConfigurationEntities context)
            : base(context)
        {
            
        }



    }
}
