using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class ExamClassManager: EntityManager<ExamClass, int>
        ,IExamClassManager
    {

        public ExamClassManager(IDrlEntities context): base(context){}

    }
}
