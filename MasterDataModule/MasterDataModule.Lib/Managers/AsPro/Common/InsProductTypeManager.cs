using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsProductTypeManager: EntityManager<InsProductType, int>
        ,IInsProductTypeManager
    {

        public InsProductTypeManager(IAsProEntities context): base(context){}

    }
}
