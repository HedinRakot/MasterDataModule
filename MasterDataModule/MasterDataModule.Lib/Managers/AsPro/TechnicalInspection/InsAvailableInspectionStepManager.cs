using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsAvailableInspectionStepManager: EntityManager<InsAvailableInspectionStep, int>
        ,IInsAvailableInspectionStepManager
    {

        public InsAvailableInspectionStepManager(IAsProEntities context): base(context){}

    }
}
