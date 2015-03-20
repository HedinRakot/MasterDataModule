using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class CoreDataProductManager: EntityManager<CoreDataProduct, int>
        ,ICoreDataProductManager
    {

        public CoreDataProductManager(IDrlEntities context): base(context){}

    }
}
