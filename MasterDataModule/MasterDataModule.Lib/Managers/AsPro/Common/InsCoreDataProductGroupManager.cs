using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsCoreDataProductGroupManager: EntityManager<InsCoreDataProductGroup, int>
        ,IInsCoreDataProductGroupManager
    {

        public InsCoreDataProductGroupManager(IAsProEntities context): base(context){}

    }
}
