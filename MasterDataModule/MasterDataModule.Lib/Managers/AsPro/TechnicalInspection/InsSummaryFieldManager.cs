using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsSummaryFieldManager: EntityManager<InsSummaryField, int>
        ,IInsSummaryFieldManager
    {

        public InsSummaryFieldManager(IAsProEntities context): base(context){}

    }
}
