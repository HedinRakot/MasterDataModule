using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="SysRoleSysPermissionRsp"/> entity
    /// </summary>
    [DataContract]
    public class SysRoleSysPermissionRspModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="SysRoleSysPermissionRsp.SysRoleId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int sysRoleId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysRoleSysPermissionRsp.SysPermissionId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int sysPermissionId{ get; set; }

    }
}
