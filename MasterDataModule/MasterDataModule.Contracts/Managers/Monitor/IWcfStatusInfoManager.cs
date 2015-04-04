
using MasterDataModule.Contracts.Entities.Configuration;
using MasterDataModule.Contracts.Entities.Monitor;
using MasterDataModule.Contracts.Managers.Base;

namespace MasterDataModule.Contracts.Managers.Monitor
{
    public interface IWcfStatusInfoManager : IEntityManager<WcfServiceStatus, int>
    {
    }
}
