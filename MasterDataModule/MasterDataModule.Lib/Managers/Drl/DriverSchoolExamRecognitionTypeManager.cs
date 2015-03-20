using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class DriverSchoolExamRecognitionTypeManager: EntityManager<DriverSchoolExamRecognitionType, int>
        ,IDriverSchoolExamRecognitionTypeManager
    {

        public DriverSchoolExamRecognitionTypeManager(IDrlEntities context): base(context){}

    }
}
