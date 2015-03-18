using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace MasterDataModule.Contracts.Entities
{
    public partial class SysTable : ISystemFields
    {
        private readonly DateTime changeDate = DateTime.MinValue;
        
        /// <summary>
        /// Stub for change date
        /// </summary>
        [NotMapped]
        public DateTime ChangeDate
        {
            get { return changeDate; }
            set {  }
        }
    }
}