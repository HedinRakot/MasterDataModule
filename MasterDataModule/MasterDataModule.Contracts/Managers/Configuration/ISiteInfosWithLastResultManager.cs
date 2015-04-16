using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using MasterDataModule.Contracts.Managers.Base;
using System;

namespace MasterDataModule.Contracts.Managers.Configuration
{
    public partial interface ISiteInfosWithLastResultManager: IEntityManager<SiteInfosWithLastResult, int>
    {
    }
}
