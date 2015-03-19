using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Contracts.Managers.Base;


namespace MasterDataModule.API.Controllers
{    
    public abstract class ViewCollectionControllerFactoryBase
    {
        protected IEnumerable<IdNameModel<TId>> GetReadOnlyViewCollection<TEntity, TId, TManager>(TManager manager)
            where TEntity : class, IHasId<TId>
            where TId : struct, IEquatable<TId>
            where TManager : IReadOnlyEntityManager<TEntity, TId>
        {
            var result = manager.GetEntities().Select(o => { return ToCollectionItem<TId>(o); });
            return result.ToList();
        }

        protected IEnumerable<IdNameModel<TId>> GetViewCollection<TEntity, TId, TManager>(TManager manager)
            where TEntity : class, IHasId<TId>, IRemovable
            where TId : struct, IEquatable<TId>
            where TManager : IEntityManager<TEntity, TId>
        {
            var result = manager.GetEntities().Where(o => !o.DeleteDate.HasValue)
                .Select(o => { return ToCollectionItem<TId>(o); });
            return result.ToList();
        }

        protected IdNameModel<TId> ToCollectionItem<TId>(IHasId<TId> item)
            where TId : struct, IEquatable<TId>
        {
            if (item is IHasTitle)
                return new IdNameModel<TId> { id = item.Id, name = ((IHasTitle)item).EntityTitle };

            return new IdNameModel<TId> { id = item.Id, name = item.Id.ToString() };
        }
    }
}
