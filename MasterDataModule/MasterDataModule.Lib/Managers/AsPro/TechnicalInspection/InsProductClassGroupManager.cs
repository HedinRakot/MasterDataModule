using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsProductClassGroupManager: EntityManager<InsProductClassGroup, int>
        ,IInsProductClassGroupManager
    {

        public InsProductClassGroupManager(IAsProEntities context): base(context){}

    }
}
