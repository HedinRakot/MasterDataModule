using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsAvailableInspectionStep"/> entity
    /// </summary>
    [DataContract]
    public class InsAvailableInspectionStepModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsAvailableInspectionStep.InsInspectionStepId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int insInspectionStepId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsAvailableInspectionStep.IsMandatory"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public bool isMandatory{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsAvailableInspectionStep.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsAvailableInspectionStep.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
