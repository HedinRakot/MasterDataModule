using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="Permission"/> entity
    /// </summary>
    [DataContract]
    public partial class PermissionModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="Permission.SystemName"/> entity
        /// </summary>
        [DataMember]
        public string systemName{ get; set; }
        /// <summary>
        ///     Model property for <see cref="Permission.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="Permission.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="Permission.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
