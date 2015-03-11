using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class EmpEmployeeOrgCostCenterRspManager: EntityManager<EmpEmployeeOrgCostCenterRsp, int>
        ,IEmpEmployeeOrgCostCenterRspManager
    {

        public EmpEmployeeOrgCostCenterRspManager(IAsProEntities context): base(context){}

    }
}
