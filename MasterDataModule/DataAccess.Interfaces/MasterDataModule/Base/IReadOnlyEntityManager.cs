using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule;
using TuevSued.V1.IT.FE.DataAccess.Interfaces;

namespace TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Base
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TId"></typeparam>
    /// <typeparam name="TDataContext"></typeparam>
    public interface IReadOnlyEntityManager<TEntity, TId, TDataContext> :
        IReadOnlyManagerBase<TEntity, TId, TDataContext>
        where TEntity : class, IHasId<TId>
        where TDataContext : class, IEntities
    {
    }   

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TId"></typeparam>
	public interface IReadOnlyEntityManager<TEntity, TId> : IReadOnlyEntityManager<TEntity, TId, IEntities>
	    where TEntity : class, IHasId<TId>
	{
	}
}
