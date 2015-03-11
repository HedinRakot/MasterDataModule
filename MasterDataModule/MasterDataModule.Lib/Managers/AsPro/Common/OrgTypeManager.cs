using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class OrgTypeManager: EntityManager<OrgType, int>
        ,IOrgTypeManager
    {

        public OrgTypeManager(IAsProEntities context): base(context){}

    }
}
