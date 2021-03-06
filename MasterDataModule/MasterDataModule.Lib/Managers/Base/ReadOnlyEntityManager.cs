﻿using System;
using System.Linq;
using System.Collections.Generic;
using TuevSued.V1.IT.FE.DataAccess.Interfaces;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Base;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule;

namespace TuevSued.V1.IT.FE.MasterDataModule.Lib.Managers.Base
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TId"></typeparam>
    /// <typeparam name="TDataContext"></typeparam>
    public class ReadOnlyEntityManager<TEntity, TId, TDataContext> :
        ReadOnlyManagerBase<TEntity, TId, TDataContext>, IReadOnlyEntityManager<TEntity, TId, TDataContext>
        where TEntity : class, IHasId<TId>
        where TId : struct, IEquatable<TId>
        where TDataContext : class, IEntities
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public ReadOnlyEntityManager(TDataContext context)
            : base(context)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override TEntity GetByID(TId id)
        {
            return DataContext.GetSet<TEntity>().SingleOrDefault(o => o.Id.Equals(id));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<TEntity> GetEntities()
        {
            return DataContext.GetSet<TEntity>();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TId"></typeparam>
	public abstract class ReadOnlyEntityManager<TEntity, TId> : ReadOnlyEntityManager<TEntity, TId, IEntities>
        where TEntity : class, IHasId<TId>
        where TId : struct, IEquatable<TId>
	{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
		public ReadOnlyEntityManager(IEntities context) :
			base(context)
		{
		}
	}
}
