using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class OrdBillingParameterManager: EntityManager<OrdBillingParameter, int>
        ,IOrdBillingParameterManager
    {

        public OrdBillingParameterManager(IAsProEntities context): base(context){}

    }
}
