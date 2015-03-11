using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers.Base;
using System;

namespace MasterDataModule.Contracts.Managers
{
    public partial interface IHolidayManager: IEntityManager<Holiday, int>
    {
    }
}
