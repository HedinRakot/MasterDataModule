using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="OrdFederalGroup"/> entity
    /// </summary>
    [DataContract]
    public class OrdFederalGroupModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="OrdFederalGroup.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrdFederalGroup.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }

    }
}
