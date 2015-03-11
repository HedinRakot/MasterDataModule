using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsProductType"/> entity
    /// </summary>
    [DataContract]
    public class InsProductTypeModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsProductType.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }

    }
}
