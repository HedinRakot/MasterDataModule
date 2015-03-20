using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class CoreDataProductLocalizationManager: EntityManager<CoreDataProductLocalization, int>
        ,ICoreDataProductLocalizationManager
    {

        public CoreDataProductLocalizationManager(IDrlEntities context): base(context){}

    }
}
