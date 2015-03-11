using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class KssExpenseGroundManager: EntityManager<KssExpenseGround, int>
        ,IKssExpenseGroundManager
    {

        public KssExpenseGroundManager(IAsProEntities context): base(context){}

    }
}
