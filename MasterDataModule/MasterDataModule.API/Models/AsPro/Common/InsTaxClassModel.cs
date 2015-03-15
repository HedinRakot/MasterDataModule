using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsTaxClass"/> entity
    /// </summary>
    [DataContract]
    public class InsTaxClassModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsTaxClass.TaxClass"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string taxClass{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsTaxClass.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsTaxClass.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
