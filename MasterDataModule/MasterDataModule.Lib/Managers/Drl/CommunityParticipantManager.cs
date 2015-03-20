using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class CommunityParticipantManager: EntityManager<CommunityParticipant, int>
        ,ICommunityParticipantManager
    {

        public CommunityParticipantManager(IDrlEntities context): base(context){}

    }
}
