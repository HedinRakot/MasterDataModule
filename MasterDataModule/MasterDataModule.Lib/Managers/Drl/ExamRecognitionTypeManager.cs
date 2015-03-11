using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class ExamRecognitionTypeManager: EntityManager<ExamRecognitionType, int>
        ,IExamRecognitionTypeManager
    {

        public ExamRecognitionTypeManager(IDrlEntities context): base(context){}

    }
}
