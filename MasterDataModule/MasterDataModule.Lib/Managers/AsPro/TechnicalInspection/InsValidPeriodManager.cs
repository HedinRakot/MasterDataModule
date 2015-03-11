using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsValidPeriodManager: EntityManager<InsValidPeriod, int>
        ,IInsValidPeriodManager
    {

        public InsValidPeriodManager(IAsProEntities context): base(context){}

    }
}
