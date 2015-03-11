using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class ExamClassRequiredClassManager: EntityManager<ExamClassRequiredClass, int>
        ,IExamClassRequiredClassManager
    {

        public ExamClassRequiredClassManager(IDrlEntities context): base(context){}

    }
}
