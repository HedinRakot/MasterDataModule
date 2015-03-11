using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class OrgAccountTypeManager: EntityManager<OrgAccountType, int>
        ,IOrgAccountTypeManager
    {

        public OrgAccountTypeManager(IAsProEntities context): base(context){}

    }
}
