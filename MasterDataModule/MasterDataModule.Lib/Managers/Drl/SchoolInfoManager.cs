using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class SchoolInfoManager: EntityManager<SchoolInfo, int>
        ,ISchoolInfoManager
    {

        public SchoolInfoManager(IDrlEntities context): base(context){}

    }
}
