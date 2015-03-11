using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsProductMaterialGroupManager: EntityManager<InsProductMaterialGroup, int>
        ,IInsProductMaterialGroupManager
    {

        public InsProductMaterialGroupManager(IAsProEntities context): base(context){}

    }
}
