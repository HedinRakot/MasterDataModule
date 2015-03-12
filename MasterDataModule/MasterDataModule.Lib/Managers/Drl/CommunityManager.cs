using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class CommunityManager: EntityManager<Community, int>
        ,ICommunityManager
    {

        public CommunityManager(IDrlEntities context): base(context){}

    }
}