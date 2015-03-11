using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class EmpEmployeeManager: EntityManager<EmpEmployee, int>
        ,IEmpEmployeeManager
    {

        public EmpEmployeeManager(IAsProEntities context): base(context){}

    }
}
