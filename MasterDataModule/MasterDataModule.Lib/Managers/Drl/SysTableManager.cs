using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class SysTableManager: EntityManager<SysTable, int>
        ,ISysTableManager
    {

        public SysTableManager(IDrlEntities context): base(context){}

    }
}
