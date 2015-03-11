using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsSummaryField"/> entity
    /// </summary>
    [DataContract]
    public class InsSummaryFieldModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsSummaryField.Description"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string description{ get; set; }

    }
}
