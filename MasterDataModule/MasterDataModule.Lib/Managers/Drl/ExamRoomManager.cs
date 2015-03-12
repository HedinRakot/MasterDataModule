using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class ExamRoomManager: EntityManager<ExamRoom, int>
        ,IExamRoomManager
    {

        public ExamRoomManager(IDrlEntities context): base(context){}

    }
}