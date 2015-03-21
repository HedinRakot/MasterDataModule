using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="OrdRecognition"/> entity
    /// </summary>
    [DataContract]
    public partial class OrdRecognitionModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="OrdRecognition.OrdRecognitionTypeId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int? ordRecognitionTypeId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrdRecognition.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrdRecognition.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrdRecognition.OrgAccountingAreaId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int? orgAccountingAreaId{ get; set; }

    }
}
