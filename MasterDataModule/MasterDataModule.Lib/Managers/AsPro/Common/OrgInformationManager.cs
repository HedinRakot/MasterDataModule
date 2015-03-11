using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class OrgInformationManager: EntityManager<OrgInformation, int>
        ,IOrgInformationManager
    {

        public OrgInformationManager(IAsProEntities context): base(context){}

    }
}
