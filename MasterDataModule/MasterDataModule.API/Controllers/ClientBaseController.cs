using System.Web.Http;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Managers.Base;

namespace MasterDataModule.API.Controllers
{
    public abstract class ClientBaseController<TModel, TEntity, TId, TManager> :
        ClientBaseWithoutDeleteController<TModel, TEntity, TId, TManager>
        where TManager : IManagerBase<TEntity, TId>
        where TModel : class, IHasId<TId>, new()
        where TEntity : class, IHasId<TId>, IRemovable
    {
        protected ClientBaseController(TManager manager)
            : base(manager)
        {
        }

        public virtual IHttpActionResult Delete(TId id)
        {
            var entity = Manager.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }

            Manager.RemoveEntity(id);

            Manager.SaveChanges();

            OnActionSuccess(entity, ActionTypes.Delete);

            return Ok(id);
        }
    }
}