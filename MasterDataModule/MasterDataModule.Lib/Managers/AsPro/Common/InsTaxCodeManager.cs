using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsTaxCodeManager: EntityManager<InsTaxCode, int>
        ,IInsTaxCodeManager
    {

        public InsTaxCodeManager(IAsProEntities context): base(context){}

    }
}
