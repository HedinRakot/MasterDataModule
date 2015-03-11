using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class SysColumnManager: EntityManager<SysColumn, int>
        ,ISysColumnManager
    {

        public SysColumnManager(IDrlEntities context): base(context){}

    }
}
