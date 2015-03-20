using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsCoreDataProductManager: EntityManager<InsCoreDataProduct, int>
        ,IInsCoreDataProductManager
    {

        public InsCoreDataProductManager(IAsProEntities context): base(context){}

    }
}
