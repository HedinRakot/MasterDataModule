using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class EmpCashPermissionTypeManager: EntityManager<EmpCashPermissionType, int>
        ,IEmpCashPermissionTypeManager
    {

        public EmpCashPermissionTypeManager(IAsProEntities context): base(context){}

    }
}