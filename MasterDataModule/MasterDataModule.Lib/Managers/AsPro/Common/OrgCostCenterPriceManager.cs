using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class OrgCostCenterPriceManager: EntityManager<OrgCostCenterPrice, int>
        ,IOrgCostCenterPriceManager
    {

        public OrgCostCenterPriceManager(IAsProEntities context): base(context){}

    }
}
