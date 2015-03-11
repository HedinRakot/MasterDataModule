using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class OrgInspectionDeviceManager: EntityManager<OrgInspectionDevice, int>
        ,IOrgInspectionDeviceManager
    {

        public OrgInspectionDeviceManager(IAsProEntities context): base(context){}

    }
}
