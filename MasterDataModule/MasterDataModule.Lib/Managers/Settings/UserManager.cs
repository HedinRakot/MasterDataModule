using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Settings;
using TuevSued.V1.IT.FE.MasterDataModule.Lib.Data;
using TuevSued.V1.IT.FE.MasterDataModule.Lib.Managers.Base;

namespace TuevSued.V1.IT.FE.MasterDataModule.Lib.Managers.Settings
{
    /// <summary>
    /// 
    /// </summary>
	public class UserManager : EntityManager<User, int>, IUserManager
	{
        public UserManager(IFeEntities context) :
            base(context)
        {
        }

		#region IUserManager Members

        /// <summary>
        /// 
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
		public User GetByLogin(string login)
		{
			return DataContext.GetSet<User>().SingleOrDefault(o => o.Login == login);
		}

        /// <summary>
        /// 
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
