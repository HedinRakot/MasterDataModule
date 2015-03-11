using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class SysRoleManager: EntityManager<SysRole, int>
        ,ISysRoleManager
    {

        public SysRoleManager(IAsProEntities context): base(context){}

    }
}
