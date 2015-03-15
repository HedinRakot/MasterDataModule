using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="SysRole"/> entity
    /// </summary>
    [DataContract]
    public class SysRoleModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="SysRole.RoleNumber"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int? roleNumber{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysRole.Name"/> entity
        /// </summary>
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysRole.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysRole.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysRole.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
