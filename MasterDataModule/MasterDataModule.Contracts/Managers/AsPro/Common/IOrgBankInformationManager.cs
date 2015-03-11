using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers.Base;
using System;

namespace MasterDataModule.Contracts.Managers
{
    public partial interface IOrgBankInformationManager: IEntityManager<OrgBankInformation, int>
    {
    }
}
