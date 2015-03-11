using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsProductObjectTypeManager: EntityManager<InsProductObjectType, int>
        ,IInsProductObjectTypeManager
    {

        public InsProductObjectTypeManager(IAsProEntities context): base(context){}

    }
}
