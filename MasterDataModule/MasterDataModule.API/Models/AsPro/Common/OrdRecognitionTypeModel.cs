using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="OrdRecognitionType"/> entity
    /// </summary>
    [DataContract]
    public class OrdRecognitionTypeModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="OrdRecognitionType.Name"/> entity
        /// </summary>
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrdRecognitionType.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrdRecognitionType.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
