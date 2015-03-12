using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="ArgeVersion"/> entity
    /// </summary>
    [DataContract]
    public class ArgeVersionModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="ArgeVersion.ProgrammName"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string programmName{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ArgeVersion.VersionSystem"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string versionSystem{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ArgeVersion.ExpirationDate"/> entity
        /// </summary>
        [DataMember]
        public DateTime expirationDate{ get; set; }

    }
}