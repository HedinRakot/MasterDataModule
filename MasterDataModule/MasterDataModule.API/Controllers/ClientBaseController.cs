using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Linq.Dynamic;
using System.Reflection;
using System.Globalization;
using System.Runtime.Serialization;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Base;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers
{
    public abstract class ClientBaseController<TModel, TEntity, TId, TManager> :
        ClientBaseWithoutDeleteController<TModel, TEntity, TId, TManager>
		where TManager : IManagerBase<TEntity, TId>
		where TModel : class, IHasId<TId>, new()
		where TEntity : class, IHasId<TId>, IRemovable
	{
        public ClientBaseController(TManager manager)
            :base(manager)
        {

        }

		public virtual IHttpActionResult Delete(TId id)
		{
			var entity = Manager.GetByID(id);
			if (entity == null)
				return NotFound();

			Manager.RemoveEntity(id);			

			Manager.SaveChanges();

			OnActionSuccess(entity, ActionTypes.Delete);

			return Ok(id);
		}			
	}
}
