namespace TuevSued.V1.IT.FE.DataAccess.Interfaces
{
    /// <summary>
    /// Control commiting changes to db
    /// </summary>
    public interface IDbCommiter
    {
        /// <summary>
        /// Save all changes  from underlying context to database and process order changes
        /// </summary>
        void SaveChanges();
    }
}