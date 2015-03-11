using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class OrdOrderCancelationReasonManager: EntityManager<OrdOrderCancelationReason, int>
        ,IOrdOrderCancelationReasonManager
    {

        public OrdOrderCancelationReasonManager(IAsProEntities context): base(context){}

    }
}
