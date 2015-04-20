using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Contracts.Managers.Configuration;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers.Configuration
{
    public partial class GetWcfServicesStatusManager: EntityManager<GetWcfServicesStatus, int>
        ,IGetWcfServicesStatusManager
    {

        public GetWcfServicesStatusManager(IMasterDataConfigurationEntities context): base(context){}

    }
}