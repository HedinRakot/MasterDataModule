using System.Data.Entity;
using System.Linq;
using MasterDataModule.Contracts;


namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     Database context for FeEntities
    /// </summary>
    public abstract class EntitiesBase : DbContext
    {
        /// <summary>
        /// Constructs a new context instance using conventions to create the name of the database to
        ///             which a connection will be made.  The by-convention name is the full name (namespace + class name)
        ///             of the derived context class.
        ///             See the class remarks for how this is used to create a connection.
        /// </summary>
        protected EntitiesBase()
        {
        }

        /// <summary>
        /// Constructs a new context instance using the given string as the name or connection string for the
        ///             database to which a connection will be made.
        ///             See the class remarks for how this is used to create a connection.
        /// </summary>
        /// <param name="nameOrConnectionString">Either the database name or a connection string. </param>
        protected EntitiesBase(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }
        /// <summary>
        ///     Gets set of entities
        /// </summary>
        /// <typeparam name="TEntity">type of entities</typeparam>
        /// <returns></returns>
        public IQueryable<TEntity> GetSet<TEntity>()
            where TEntity : class
        {
            return Set<TEntity>();
        }

        /// <summary>
        ///     Add entity in context
        /// </summary>
        /// <typeparam name="TEntity">Type of adding entity</typeparam>
        /// <param name="entity">Adding entity</param>
        public void AddObject<TEntity>(TEntity entity)
            where TEntity : class
        {
            Set<TEntity>().Add(entity);
        }

        /// <summary>
        ///     Create entity without adding it to context. Use <see cref="IEntities.AddObject{TEntity}" /> to add object to
        ///     context
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        public TEntity CreateObject<TEntity>() where TEntity : class
        {
            return Set<TEntity>().Create();
        }

        /// <summary>
        ///     Update entity in context
        /// </summary>
        /// <typeparam name="TEntity">Type of updating entity</typeparam>
        /// <param name="entity">Updating entity</param>
        public void UpdateObject<TEntity>(TEntity entity)
            where TEntity : class
        {
            //var entry = Entry(entity);
            //entry.State = EntityState.Modified;
        }

        /// <summary>
        ///     Delete entity in context
        /// </summary>
        /// <typeparam name="TEntity">Type of deleting entity</typeparam>
        /// <param name="entity">Deleting entity</param>
        public void DeleteObject<TEntity>(TEntity entity)
            where TEntity : class
        {
            Set<TEntity>().Remove(entity);
        }
    }
}