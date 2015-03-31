using System.Linq;

namespace MonitoringAgent.Data.Interfaces.Managers
{
    public interface IBaseManager<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAllEntities();
        void AddOrUpdateEntities(TEntity[] entities);
        void SaveChanges();
    }
}