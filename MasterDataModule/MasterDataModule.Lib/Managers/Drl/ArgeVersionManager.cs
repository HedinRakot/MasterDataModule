using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class ArgeVersionManager: EntityManager<ArgeVersion, int>
        ,IArgeVersionManager
    {

        public ArgeVersionManager(IDrlEntities context): base(context){}

    }
}
