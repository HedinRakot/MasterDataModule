using System.Collections.Generic;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    public partial class Role
    {
        private ICollection<Permission> _permissions = new HashSet<Permission>();
        /// <summary>
        ///     Permissions will be loaded in Manager
        /// </summary>
        public ICollection<Permission> Permissions
        {
            get { return _permissions; }
            set { _permissions = value; }
        }
    }
}