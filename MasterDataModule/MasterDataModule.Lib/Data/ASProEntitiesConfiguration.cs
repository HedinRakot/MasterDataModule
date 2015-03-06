using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;

namespace TuevSued.V1.IT.FE.MasterDataModule.Lib.Data
{
    internal class ASProEntitiesConfiguration : DbConfiguration
    {
        public ASProEntitiesConfiguration()
        {
            SetProviderServices("System.Data.SqlClient", SqlProviderServices.Instance);
            SetExecutionStrategy("System.Data.SqlClient", () => new DefaultExecutionStrategy());
            SetDefaultConnectionFactory(new LocalDbConnectionFactory("v11.0"));
        }
    }
}