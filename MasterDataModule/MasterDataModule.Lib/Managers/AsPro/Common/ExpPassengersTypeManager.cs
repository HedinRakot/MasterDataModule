using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class ExpPassengersTypeManager: EntityManager<ExpPassengersType, int>
        ,IExpPassengersTypeManager
    {

        public ExpPassengersTypeManager(IAsProEntities context): base(context){}

    }
}
