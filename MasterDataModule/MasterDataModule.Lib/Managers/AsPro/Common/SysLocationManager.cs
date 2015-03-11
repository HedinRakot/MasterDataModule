using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class SysLocationManager: EntityManager<SysLocation, int>
        ,ISysLocationManager
    {

        public SysLocationManager(IAsProEntities context): base(context){}

    }
}
