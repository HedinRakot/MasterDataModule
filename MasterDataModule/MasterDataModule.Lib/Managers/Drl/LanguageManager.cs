using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class LanguageManager: EntityManager<Language, int>
        ,ILanguageManager
    {

        public LanguageManager(IDrlEntities context): base(context){}

    }
}
