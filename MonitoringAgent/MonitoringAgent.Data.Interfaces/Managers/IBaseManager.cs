using MonitoringAgent.Data.Interfaces.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MonitoringAgent.Data.Interfaces.Managers
{
    public interface IBaseManager<TEntity> where TEntity : class, ISystemFields
    {
        IQueryable<TEntity> GetAllEntities();
        void AddOrUpdateEntities(TEntity[] entities);
        void SaveChanges();
    }
}