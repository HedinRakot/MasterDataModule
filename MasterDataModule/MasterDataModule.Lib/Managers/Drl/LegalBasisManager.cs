using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class LegalBasisManager: EntityManager<LegalBasis, int>
        ,ILegalBasisManager
    {

        public LegalBasisManager(IDrlEntities context): base(context){}

    }
}
