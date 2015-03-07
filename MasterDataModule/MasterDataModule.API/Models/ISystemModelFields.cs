using System;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Models
{
    /// <summary>
    /// Interface model with system fields 
    /// </summary>
    public interface ISystemModelFields
    {
        /// <summary>
        /// From date entity valid 
        /// </summary>
        DateTime fromDate { get; set; }
        
        /// <summary>
        /// To date entity valid 
        /// </summary>
        DateTime toDate { get; set; }

        /// <summary>
        /// Change date from entity 
        /// </summary>
        DateTime ChangeDate { get; set; }
    }
}
