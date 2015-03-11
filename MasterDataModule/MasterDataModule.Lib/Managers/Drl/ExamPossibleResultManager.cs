using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class ExamPossibleResultManager: EntityManager<ExamPossibleResult, int>
        ,IExamPossibleResultManager
    {

        public ExamPossibleResultManager(IDrlEntities context): base(context){}

    }
}
