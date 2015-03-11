using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsAvailableInspectionTextValueManager: EntityManager<InsAvailableInspectionTextValue, int>
        ,IInsAvailableInspectionTextValueManager
    {

        public InsAvailableInspectionTextValueManager(IAsProEntities context): base(context){}

    }
}
