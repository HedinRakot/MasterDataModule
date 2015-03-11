using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class InsPfpVehicleTypeManager: EntityManager<InsPfpVehicleType, int>
        ,IInsPfpVehicleTypeManager
    {

        public InsPfpVehicleTypeManager(IAsProEntities context): base(context){}

    }
}
