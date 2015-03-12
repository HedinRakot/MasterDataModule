using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsTaxCode"/> entity
    /// </summary>
    [DataContract]
    public class InsTaxCodeModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsTaxCode.TaxCode"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string taxCode{ get; set; }

    }
}