using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="Role"/> entity
    /// </summary>
    [DataContract]
    public partial class RoleModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="Role.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="Role.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="Role.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
