using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class SysPostCodeManager: EntityManager<SysPostCode, int>
        ,ISysPostCodeManager
    {

        public SysPostCodeManager(IAsProEntities context): base(context){}

    }
}
