using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class ExamConstraintManager: EntityManager<ExamConstraint, int>
        ,IExamConstraintManager
    {

        public ExamConstraintManager(IDrlEntities context): base(context){}

    }
}
