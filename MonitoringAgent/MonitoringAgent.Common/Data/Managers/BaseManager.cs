using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace MonitoringAgent.Common.Data.Managers
{
    public abstract class BaseManager<TEntity> where TEntity : class
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
    }
}