using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class ExamStationManager: EntityManager<ExamStation, int>
        ,IExamStationManager
    {

        public ExamStationManager(IDrlEntities context): base(context){}

    }
}
