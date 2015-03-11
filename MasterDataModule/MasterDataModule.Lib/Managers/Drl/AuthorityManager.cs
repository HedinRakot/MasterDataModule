using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class AuthorityManager: EntityManager<Authority, int>
        ,IAuthorityManager
    {

        public AuthorityManager(IDrlEntities context): base(context){}

    }
}
