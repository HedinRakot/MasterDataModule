using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class OrdContactPersonFunctionManager: EntityManager<OrdContactPersonFunction, int>
        ,IOrdContactPersonFunctionManager
    {

        public OrdContactPersonFunctionManager(IAsProEntities context): base(context){}

    }
}
