using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace MasterDataModule.Lib.Data
{
    /// <summary>
    ///     FeEntities
    /// </summary>
    [DbConfigurationType(typeof (FeEntitiesConfiguration))]
    public partial class DrlEntities: EntitiesBase
    {
        /// <summary>
        /// </summary>
        /// <param name="connectionString"></param>
        public DrlEntities(string connectionString)
            : base(connectionString)
        {
        }

        static DrlEntities()
        {
            Database.SetInitializer<DrlEntities>(null);
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DrlEntities" /> class.
        /// </summary>
        public DrlEntities()
            : base("name=FeEntities")
        {
        }

        /// <summary>
        ///     Saves changes only
        /// </summary>
        protected void SaveChangesInternal()
        {
            try
            {
                base.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
#if DEBUG
                foreach (var eve in e.EntityValidationErrors)
                {
                    Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name,
                        eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName,
                            ve.ErrorMessage);
                    }
                }
#endif //DEBUG
                throw;
            }
        }

        /// <summary>
        ///     Add entity to context
        /// </summary>
        /// <typeparam name="TEntity">Type of adding entity</typeparam>
        /// <param name="entities">Adding entities</param>
        public void AddRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
        {
            Set<TEntity>().AddRange(entities);
        }

        /// <summary>
        ///     Save all changes from underlying context to database
        /// </summary>
        public new virtual void SaveChanges()
        {
            SaveChangesInternal();
        }

        /// <summary>
        ///     Object context
        /// </summary>
        public ObjectContext ObjectContext
        {
            get { return ((IObjectContextAdapter) this).ObjectContext; }
        }

        /// <summary> Throws InvalidOperationException if there is any change in DbContext after the last changes saving. </summary>
        public void ThrowIfHasChange()
        {
            foreach (var item in ChangeTracker.Entries())
            {
                if (item.State != EntityState.Unchanged)
                {
                    throw new InvalidOperationException(
                        string.Format("Unexpected FeEntities' changes are detected for entity of type: {0}",
                            item.Entity == null ? null : item.Entity.GetType().FullName));
                }
            }
        }
    }
}