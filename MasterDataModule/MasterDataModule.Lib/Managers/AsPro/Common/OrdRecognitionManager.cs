using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class OrdRecognitionManager: EntityManager<OrdRecognition, int>
        ,IOrdRecognitionManager
    {

        public OrdRecognitionManager(IAsProEntities context): base(context){}

    }
}
