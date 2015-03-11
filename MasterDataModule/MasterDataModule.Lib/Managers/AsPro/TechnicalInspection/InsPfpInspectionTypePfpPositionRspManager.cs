using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsPfpInspectionTypePfpPositionRspManager: EntityManager<InsPfpInspectionTypePfpPositionRsp, int>
        ,IInsPfpInspectionTypePfpPositionRspManager
    {

        public InsPfpInspectionTypePfpPositionRspManager(IAsProEntities context): base(context){}

    }
}
