using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class PermissionManager: EntityManager<Permission, int>
        ,IPermissionManager
    {

        public PermissionManager(IDrlEntities context): base(context){}

    }
}
