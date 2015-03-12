using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class OrgCostCenterResponsibleEmployeeRspManager: EntityManager<OrgCostCenterResponsibleEmployeeRsp, int>
        ,IOrgCostCenterResponsibleEmployeeRspManager
    {

        public OrgCostCenterResponsibleEmployeeRspManager(IAsProEntities context): base(context){}

    }
}