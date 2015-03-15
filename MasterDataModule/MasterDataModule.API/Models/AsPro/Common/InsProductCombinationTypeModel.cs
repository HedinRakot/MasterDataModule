using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsProductCombinationType"/> entity
    /// </summary>
    [DataContract]
    public class InsProductCombinationTypeModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsProductCombinationType.Description"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsProductCombinationType.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsProductCombinationType.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
