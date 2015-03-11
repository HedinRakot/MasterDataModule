using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsUnitCodeManager: EntityManager<InsUnitCode, int>
        ,IInsUnitCodeManager
    {

        public InsUnitCodeManager(IAsProEntities context): base(context){}

    }
}
