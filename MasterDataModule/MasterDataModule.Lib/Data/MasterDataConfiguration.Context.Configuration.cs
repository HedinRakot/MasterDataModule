using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;

namespace MasterDataModule.Lib.Data
{
    internal class MasterDataConfigurationConfiguration : DbConfiguration
    {
        public MasterDataConfigurationConfiguration()
        {
            SetProviderServices("System.Data.SqlClient", SqlProviderServices.Instance);
            SetExecutionStrategy("System.Data.SqlClient", () => new DefaultExecutionStrategy());
            //SetDefaultConnectionFactory(new LocalDbConnectionFactory("v11.0"));
        }
    }
}