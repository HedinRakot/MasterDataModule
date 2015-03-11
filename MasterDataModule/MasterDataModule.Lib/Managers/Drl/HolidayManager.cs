using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class HolidayManager: EntityManager<Holiday, int>
        ,IHolidayManager
    {

        public HolidayManager(IDrlEntities context): base(context){}

    }
}
