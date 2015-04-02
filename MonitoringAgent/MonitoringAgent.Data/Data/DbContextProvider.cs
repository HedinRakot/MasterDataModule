using System.Data.Entity;

namespace MonitoringAgent.Common.Data
{
    public class DbContextProvider
    {
        public DbContext GetContext()
        {
            return new MasterDataDbContext();
        }
    }
}
