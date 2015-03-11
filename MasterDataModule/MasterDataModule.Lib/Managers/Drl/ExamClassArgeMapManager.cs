using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class ExamClassArgeMapManager: EntityManager<ExamClassArgeMap, int>
        ,IExamClassArgeMapManager
    {

        public ExamClassArgeMapManager(IDrlEntities context): base(context){}

    }
}
