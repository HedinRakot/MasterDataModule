using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsCoreDataProductLocalizationManager: EntityManager<InsCoreDataProductLocalization, int>
        ,IInsCoreDataProductLocalizationManager
    {

        public InsCoreDataProductLocalizationManager(IAsProEntities context): base(context){}

    }
}
