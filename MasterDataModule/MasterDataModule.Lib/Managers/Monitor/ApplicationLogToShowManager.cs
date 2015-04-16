using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities.Monitor;
using MasterDataModule.Contracts.Managers.Monitor;
using MasterDataModule.Lib.Managers.Base;

namespace MasterDataModule.Lib.Managers.Monitor
{

    public partial class ApplicationLogToShowManager : EntityManager<ApplicationLogToShow, int>,
        IApplicationLogToShowManager
    {
        public ApplicationLogToShowManager(IMasterDataConfigurationEntities context)
            : base(context)
        {

        }
    }
}
