using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsNextInspectionManager: EntityManager<InsNextInspection, int>
        ,IInsNextInspectionManager
    {

        public InsNextInspectionManager(IAsProEntities context): base(context){}

    }
}
