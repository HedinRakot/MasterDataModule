using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.Managers.Base;
using System;

namespace MasterDataModule.Lib.Managers
{
    public partial class UserManager: EntityManager<User, int>
        ,IUserManager
    {

        public UserManager(IDrlEntities context): base(context){}

    }
}
