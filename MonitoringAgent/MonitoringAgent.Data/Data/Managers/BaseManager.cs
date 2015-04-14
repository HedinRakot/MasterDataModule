﻿using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using MonitoringAgent.Data.Interfaces.Managers;
using System;
using MonitoringAgent.Data.Interfaces.Entities;

namespace MonitoringAgent.Common.Data.Managers
{
    public abstract class BaseManager<TEntity> : IBaseManager<TEntity> where TEntity : class, ISystemFields
    {
        private readonly DbContext context;

        protected BaseManager(DbContext context)
        {
            this.context = context;
        }

        public IQueryable<TEntity> GetAllEntities()
        {
            return context.Set<TEntity>().Where(o => !o.DeleteDate.HasValue).AsNoTracking();
        }

        public void AddOrUpdateEntities(TEntity[] entities)
        {
            context.Set<TEntity>().AddOrUpdate(entities);
        }

        public void SaveChanges()
        {
            foreach (var entry in context.ChangeTracker.Entries())
            {
                ((ISystemFields)entry.Entity).ChangeDate = DateTime.Now;
            }
            context.SaveChanges();
        }
    }
}