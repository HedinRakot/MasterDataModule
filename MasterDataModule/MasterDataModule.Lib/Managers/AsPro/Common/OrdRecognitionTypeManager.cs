using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class OrdRecognitionTypeManager: EntityManager<OrdRecognitionType, int>
        ,IOrdRecognitionTypeManager
    {

        public OrdRecognitionTypeManager(IAsProEntities context): base(context){}

    }
}
