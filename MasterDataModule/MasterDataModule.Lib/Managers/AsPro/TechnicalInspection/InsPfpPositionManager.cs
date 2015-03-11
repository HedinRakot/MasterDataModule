using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsPfpPositionManager: EntityManager<InsPfpPosition, int>
        ,IInsPfpPositionManager
    {

        public InsPfpPositionManager(IAsProEntities context): base(context){}

    }
}
