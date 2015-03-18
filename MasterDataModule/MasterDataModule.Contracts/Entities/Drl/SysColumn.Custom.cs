using System;
using System.Collections.Generic;

namespace MasterDataModule.Contracts.Entities
{
    public partial class SysColumn : ISystemFields
    {
        /// <summary>
        /// Stub for change date
        /// </summary>
        public DateTime ChangeDate
        {
            get { return DateTime.MinValue; }
            set { }
        }
    }
}