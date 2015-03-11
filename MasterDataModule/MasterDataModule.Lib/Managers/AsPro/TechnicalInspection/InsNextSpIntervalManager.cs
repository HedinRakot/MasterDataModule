using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsNextSpIntervalManager: EntityManager<InsNextSpInterval, int>
        ,IInsNextSpIntervalManager
    {

        public InsNextSpIntervalManager(IAsProEntities context): base(context){}

    }
}
