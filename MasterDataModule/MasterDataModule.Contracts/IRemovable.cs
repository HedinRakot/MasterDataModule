using System;

namespace MasterDataModule.Contracts
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
