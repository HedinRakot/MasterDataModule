using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using MonitoringAgent.Data.Interfaces.Managers;

namespace MonitoringAgent.Common.Data.Managers
{
    public abstract class BaseManager<TEntity> : IBaseManager<TEntity> where TEntity : class
    {
        private readonly DbContext context;

        protected BaseManager(DbContext context)
        {
            this.context = context;
        }

        public IQueryable<TEntity> GetAllEntities()
        {
            return context.Set<TEntity>();
        }

        public void AddOrUpdateEntities(TEntity[] entities)
        {
            context.Set<TEntity>().AddOrUpdate(entities);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}