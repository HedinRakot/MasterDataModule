using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class EmpEmployeeSysRoleRspManager: EntityManager<EmpEmployeeSysRoleRsp, int>
        ,IEmpEmployeeSysRoleRspManager
    {

        public EmpEmployeeSysRoleRspManager(IAsProEntities context): base(context){}

    }
}
