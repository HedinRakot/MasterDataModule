using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class ExamConstraintExamClassManager: EntityManager<ExamConstraintExamClass, int>
        ,IExamConstraintExamClassManager
    {

        public ExamConstraintExamClassManager(IDrlEntities context): base(context){}

    }
}
