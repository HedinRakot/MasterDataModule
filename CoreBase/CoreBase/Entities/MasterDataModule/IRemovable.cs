using System;
using System.Collections.Generic;

namespace TuevSued.V1.IT.CoreBase.Entities.MasterDataModule
{
    /// <summary>
    /// Interface entity with Delete Data
    /// </summary>
    public interface IRemovable
    {
        /// <summary>
        /// Delete date entity 
        /// </summary>
        DateTime? DeleteDate { get; set; }
    }
}
