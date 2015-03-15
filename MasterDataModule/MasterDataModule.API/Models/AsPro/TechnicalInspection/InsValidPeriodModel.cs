using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsValidPeriod"/> entity
    /// </summary>
    [DataContract]
    public class InsValidPeriodModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsValidPeriod.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsValidPeriod.ValidityPeriod"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int? validityPeriod{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsValidPeriod.IsNextTerminPossible"/> entity
        /// </summary>
        [DataMember]
        public bool? isNextTerminPossible{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsValidPeriod.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsValidPeriod.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
