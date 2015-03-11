using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="ExpPassengersType"/> entity
    /// </summary>
    [DataContract]
    public class ExpPassengersTypeModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="ExpPassengersType.Text"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string text{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExpPassengersType.Code"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string code{ get; set; }

    }
}
