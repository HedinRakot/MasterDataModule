using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsStatisticGroupManager: EntityManager<InsStatisticGroup, int>
        ,IInsStatisticGroupManager
    {

        public InsStatisticGroupManager(IAsProEntities context): base(context){}

    }
}
