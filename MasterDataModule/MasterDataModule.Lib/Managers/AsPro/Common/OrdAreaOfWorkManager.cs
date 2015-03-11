using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class OrdAreaOfWorkManager: EntityManager<OrdAreaOfWork, int>
        ,IOrdAreaOfWorkManager
    {

        public OrdAreaOfWorkManager(IAsProEntities context): base(context){}

    }
}
