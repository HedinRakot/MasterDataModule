using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class OrgRelationshipTypeManager: EntityManager<OrgRelationshipType, int>
        ,IOrgRelationshipTypeManager
    {

        public OrgRelationshipTypeManager(IAsProEntities context): base(context){}

    }
}
