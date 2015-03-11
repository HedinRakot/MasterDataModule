using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsObdStatusManager: EntityManager<InsObdStatus, int>
        ,IInsObdStatusManager
    {

        public InsObdStatusManager(IAsProEntities context): base(context){}

    }
}
