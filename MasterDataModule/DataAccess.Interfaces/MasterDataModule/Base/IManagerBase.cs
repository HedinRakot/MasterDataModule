﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule;
using TuevSued.V1.IT.FE.DataAccess.Interfaces;

namespace TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Base
{   
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TId"></typeparam>
	public interface IManagerBase<TEntity, TId> : IReadOnlyManagerBase<TEntity, TId>
        where TEntity : IHasId<TId>, IRemovable
	{
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
		TEntity CreateEntity();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
		void AddEntity(TEntity entity);
		
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
		bool RemoveEntity(TEntity entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool RemoveEntity(TId id);
	}
    
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TId"></typeparam>
    /// <typeparam name="TDataContext"></typeparam>
	public interface IManagerBase<TEntity, TId, TDataContext> : 
        IManagerBase<TEntity, TId>, IReadOnlyManagerBase<TEntity, TId, TDataContext>
		where TDataContext : IEntities
        where TEntity : IHasId<TId>, IRemovable
	{
		
	}
}
