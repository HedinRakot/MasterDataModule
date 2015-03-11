using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsOpticalDefectManager: EntityManager<InsOpticalDefect, int>
        ,IInsOpticalDefectManager
    {

        public InsOpticalDefectManager(IAsProEntities context): base(context){}

    }
}
