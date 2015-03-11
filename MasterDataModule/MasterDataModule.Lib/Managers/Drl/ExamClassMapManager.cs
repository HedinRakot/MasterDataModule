using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class ExamClassMapManager: EntityManager<ExamClassMap, int>
        ,IExamClassMapManager
    {

        public ExamClassMapManager(IDrlEntities context): base(context){}

    }
}
