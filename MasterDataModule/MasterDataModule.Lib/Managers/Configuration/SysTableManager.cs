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

        public SysTableManager(IMasterDataConfigurationEntities context): base(context){}

    }
}
