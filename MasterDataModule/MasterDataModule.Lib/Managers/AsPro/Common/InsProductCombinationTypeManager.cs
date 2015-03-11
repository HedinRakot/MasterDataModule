using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsProductCombinationTypeManager: EntityManager<InsProductCombinationType, int>
        ,IInsProductCombinationTypeManager
    {

        public InsProductCombinationTypeManager(IAsProEntities context): base(context){}

    }
}
