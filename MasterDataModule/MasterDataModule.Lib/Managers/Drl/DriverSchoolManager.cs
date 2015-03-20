using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class DriverSchoolManager: EntityManager<DriverSchool, int>
        ,IDriverSchoolManager
    {

        public DriverSchoolManager(IDrlEntities context): base(context){}

    }
}
