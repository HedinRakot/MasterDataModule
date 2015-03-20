using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class OrgOrganizationalUnitManager: EntityManager<OrgOrganizationalUnit, int>
        ,IOrgOrganizationalUnitManager
    {

        public OrgOrganizationalUnitManager(IAsProEntities context): base(context){}

    }
}
