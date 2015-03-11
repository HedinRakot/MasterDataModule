using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class ExamRecognitionTypeExamClassManager: EntityManager<ExamRecognitionTypeExamClass, int>
        ,IExamRecognitionTypeExamClassManager
    {

        public ExamRecognitionTypeExamClassManager(IDrlEntities context): base(context){}

    }
}
