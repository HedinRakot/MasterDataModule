using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities.Monitor;
using MasterDataModule.Contracts.Managers.Monitor;
using MasterDataModule.Lib.Managers.Base;

namespace MasterDataModule.Lib.Managers.Monitor
{

    public partial class JobStatusInfoManager : EntityManager<JobStatus, int>, IJobStatusInfoManager
    {

        public JobStatusInfoManager(IMasterDataConfigurationEntities context)
            : base(context)
        {
            
        }



    }
}
