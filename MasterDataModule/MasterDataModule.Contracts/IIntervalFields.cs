using System;

namespace MasterDataModule.Contracts
{
    /// <summary>
    /// Interface entity with all system fields 
    /// </summary>
    public interface IIntervalFields
    {
        /// <summary>
        /// From date entity valid 
        /// </summary>
        DateTime? FromDate { get; set; }
        /// <summary>
        /// To date entity valid 
        /// </summary>
        DateTime? ToDate { get; set; }
    }
}