using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsTaxClassManager: EntityManager<InsTaxClass, int>
        ,IInsTaxClassManager
    {

        public InsTaxClassManager(IAsProEntities context): base(context){}

    }
}
