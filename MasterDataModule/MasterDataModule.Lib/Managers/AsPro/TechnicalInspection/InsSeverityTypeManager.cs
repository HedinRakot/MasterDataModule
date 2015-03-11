using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsSeverityTypeManager: EntityManager<InsSeverityType, int>
        ,IInsSeverityTypeManager
    {

        public InsSeverityTypeManager(IAsProEntities context): base(context){}

    }
}
