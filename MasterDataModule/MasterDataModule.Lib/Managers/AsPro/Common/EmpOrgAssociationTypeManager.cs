using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class EmpOrgAssociationTypeManager: EntityManager<EmpOrgAssociationType, int>
        ,IEmpOrgAssociationTypeManager
    {

        public EmpOrgAssociationTypeManager(IAsProEntities context): base(context){}

    }
}
