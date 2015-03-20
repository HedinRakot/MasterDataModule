using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class DriverSchoolInfoManager: EntityManager<DriverSchoolInfo, int>
        ,IDriverSchoolInfoManager
    {

        public DriverSchoolInfoManager(IDrlEntities context): base(context){}

    }
}
