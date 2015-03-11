using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class OrdRecognitionAreaOfWorkRspManager: EntityManager<OrdRecognitionAreaOfWorkRsp, int>
        ,IOrdRecognitionAreaOfWorkRspManager
    {

        public OrdRecognitionAreaOfWorkRspManager(IAsProEntities context): base(context){}

    }
}
