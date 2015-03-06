using System;
using System.Linq.Expressions;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule;

namespace TuevSued.V1.IT.CoreBase.Entities
{
    /// <summary> Filter by <see cref="ISystemFields.FromDate"/> and <see cref="ISystemFields.ToDate"/> </summary>
    /// <typeparam name="TEntity"></typeparam>
    public static class SystemFilter<TEntity>
        where TEntity : ISystemFields
    {
        /// <summary> Filter for LINQ to Entities </summary>
        public static readonly Expression<Func<TEntity, bool>> Expression = EntityCastRemoverVisitor<TEntity, ICommonSystemFields>.Convert(ent =>
            (!ent.FromDate.HasValue || ent.FromDate.Value <= DateTime.Now) &&
            (!ent.ToDate.HasValue || DateTime.Now <= ent.ToDate.Value));

        /// <summary> Filter for LINQ to Objects </summary>
        public static readonly Func<TEntity, bool> Func = ent =>
            (!ent.FromDate.HasValue || ent.FromDate.Value <= DateTime.Now) &&
            (!ent.ToDate.HasValue || DateTime.Now <= ent.ToDate.Value);
    }
}