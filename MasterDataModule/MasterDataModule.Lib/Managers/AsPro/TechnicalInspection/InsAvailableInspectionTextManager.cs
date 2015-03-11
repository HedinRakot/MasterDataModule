using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsAvailableInspectionTextManager: EntityManager<InsAvailableInspectionText, int>
        ,IInsAvailableInspectionTextManager
    {

        public InsAvailableInspectionTextManager(IAsProEntities context): base(context){}

    }
}
