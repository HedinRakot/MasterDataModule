using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class OrgBankInformationManager: EntityManager<OrgBankInformation, int>
        ,IOrgBankInformationManager
    {

        public OrgBankInformationManager(IAsProEntities context): base(context){}

    }
}
