using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class OrgCostCenterManager: EntityManager<OrgCostCenter, int>
        ,IOrgCostCenterManager
    {

        public OrgCostCenterManager(IAsProEntities context): base(context){}

    }
}
