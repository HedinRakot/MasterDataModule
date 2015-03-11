using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class SysLanguageManager: EntityManager<SysLanguage, int>
        ,ISysLanguageManager
    {

        public SysLanguageManager(IAsProEntities context): base(context){}

    }
}
