using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class OrdFederalGroupManager: EntityManager<OrdFederalGroup, int>
        ,IOrdFederalGroupManager
    {

        public OrdFederalGroupManager(IAsProEntities context): base(context){}

    }
}
