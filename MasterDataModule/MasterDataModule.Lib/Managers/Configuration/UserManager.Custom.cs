using System;
using System.Linq;
using MasterDataModule.Contracts.Entities.Configuration;

namespace MasterDataModule.Lib.Managers.Configuration
{
    /// <summary>
    /// </summary>
    public partial class UserManager
    {
        #region IUserManager Members
        /// <summary>
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public User GetByLogin(string login)
        {
            return DataContext.GetSet<User>().SingleOrDefault(o => o.Login == login);
        }

        /// <summary>
        /// </summary>
        /// <param name="entity"></param>
        protected override void DoRemove(User entity)
        {
            entity.Login = entity.Login + "_" + Guid.NewGuid();

            base.DoRemove(entity);
        }
        #endregion
    }
}