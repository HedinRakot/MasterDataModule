using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="OrgType"/> entity
    /// </summary>
    [DataContract]
    public class OrgTypeModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="OrgType.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgType.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }

    }
}
