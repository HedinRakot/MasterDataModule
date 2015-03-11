using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsPfpPosition"/> entity
    /// </summary>
    [DataContract]
    public class InsPfpPositionModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsPfpPosition.Text"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string text{ get; set; }

    }
}
