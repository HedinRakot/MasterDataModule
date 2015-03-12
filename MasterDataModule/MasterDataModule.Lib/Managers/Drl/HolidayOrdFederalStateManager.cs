using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class HolidayOrdFederalStateManager: EntityManager<HolidayOrdFederalState, int>
        ,IHolidayOrdFederalStateManager
    {

        public HolidayOrdFederalStateManager(IDrlEntities context): base(context){}

    }
}