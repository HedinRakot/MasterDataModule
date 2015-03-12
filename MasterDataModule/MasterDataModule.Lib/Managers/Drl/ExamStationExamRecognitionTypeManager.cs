using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class ExamStationExamRecognitionTypeManager: EntityManager<ExamStationExamRecognitionType, int>
        ,IExamStationExamRecognitionTypeManager
    {

        public ExamStationExamRecognitionTypeManager(IDrlEntities context): base(context){}

    }
}