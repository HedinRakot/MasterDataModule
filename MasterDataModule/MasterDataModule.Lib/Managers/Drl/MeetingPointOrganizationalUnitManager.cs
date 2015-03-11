using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class MeetingPointOrganizationalUnitManager: EntityManager<MeetingPointOrganizationalUnit, int>
        ,IMeetingPointOrganizationalUnitManager
    {

        public MeetingPointOrganizationalUnitManager(IDrlEntities context): base(context){}

    }
}
