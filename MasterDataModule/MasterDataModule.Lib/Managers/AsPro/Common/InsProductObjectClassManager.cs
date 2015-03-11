using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsProductObjectClassManager: EntityManager<InsProductObjectClass, int>
        ,IInsProductObjectClassManager
    {

        public InsProductObjectClassManager(IAsProEntities context): base(context){}

    }
}
