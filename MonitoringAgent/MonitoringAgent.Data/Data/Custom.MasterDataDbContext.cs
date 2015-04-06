using System;
using MonitoringAgent.Data.Interfaces.Entities;

namespace MonitoringAgent.Common.Data
{
    public partial class MasterDataDbContext
    {
        /// <summary>
        /// Save changes
        /// </summary>
        public new int SaveChanges()
        {

            return base.SaveChanges();
        }
    }
}
