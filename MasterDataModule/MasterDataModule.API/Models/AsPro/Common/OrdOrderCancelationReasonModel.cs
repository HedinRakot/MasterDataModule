using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="OrdOrderCancelationReason"/> entity
    /// </summary>
    [DataContract]
    public class OrdOrderCancelationReasonModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="OrdOrderCancelationReason.CancelationReasonText"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string cancelationReasonText{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrdOrderCancelationReason.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrdOrderCancelationReason.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
