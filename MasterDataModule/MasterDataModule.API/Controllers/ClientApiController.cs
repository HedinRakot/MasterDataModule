using TuevSued.V1.IT.FE.MasterDataModule.API.SystemLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Base;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Settings;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers
{
    public abstract class ReadOnlyClientApiController<TModel, TEntity, TId, TManager> : 
        ReadOnlyClientBaseController<TModel, TEntity, TId, TManager>
        where TManager : class, IReadOnlyManagerBase<TEntity, TId>
        where TModel : class, IHasId<TId>, new()
        where TEntity : class, IHasId<TId>
    {
        public ReadOnlyClientApiController(TManager manager)
            : base(manager)
		{
		}
    }

    public abstract class ClientApiWithoutDeleteController<TModel, TEntity, TId, TManager> :
        ClientBaseWithoutDeleteController<TModel, TEntity, TId, TManager>
        where TManager : class, IManagerBase<TEntity, TId>
        where TModel : class, IHasId<TId>, new()
        where TEntity : class, IHasId<TId>, IRemovable
    {
        public ClientApiWithoutDeleteController(TManager manager)
            : base(manager)
		{
		}        
    }
    
    public abstract class ClientApiController<TModel, TEntity, TId, TManager> : 
        ClientBaseController<TModel, TEntity, TId, TManager>
		where TManager : class, IManagerBase<TEntity, TId>
		where TModel : class, IHasId<TId>, new()
		where TEntity : class, IHasId<TId>, IRemovable
	{
        protected ClientApiController(TManager manager)
            : base(manager)
		{
			ActionSuccess += ClientBaseController_ActionSuccess;
		}

        [Dependency]
        public IUserManager UserManager { get; set; }

        private User GetCurrentUser()
        {
            var login = ActionContext.RequestContext.Principal.Identity.Name;
            return UserManager.GetByLogin(login);
        }

        protected IEntityLogger<TEntity> Logger
		{
			get
			{
				var type = this.GetType();
				var attr = type.GetCustomAttributes(typeof(EntityLoggerAttribute), true).FirstOrDefault() as EntityLoggerAttribute;

				var user = GetCurrentUser();
				var login = user.Name + " (" + user.Login + ")";

				if (attr != null)
					return new EntityLogger<TEntity>(login, /*attr.SystemLogRecordType, */attr.EntityGender, attr.EntityName);

				return null;
			}
		}

		private void ClientBaseController_ActionSuccess(object sender, ActionSuccessEventArgs<TEntity, TId> e)
		{
			if (Logger == null)
				return;

			switch (e.ActionType)
			{
				case ActionTypes.Add:
					Logger.AddEntity(e.Entity);
					break;
				case ActionTypes.Update:
					Logger.UpdateEntity(e.Entity);
					break;
				case ActionTypes.Delete:
					Logger.DeleteEntity(e.Entity);
					break;
			}
		}

        protected override IQueryable<TEntity> GetEntities()
        {
            return base.GetEntities().Where(o => !o.DeleteDate.HasValue);
        }
	}
}
