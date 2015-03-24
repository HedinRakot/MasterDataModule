using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="MasterDataRolePermissionRsp"/> entity
    /// </summary>
    [DataContract]
    public partial class MasterDataRolePermissionRspModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="MasterDataRolePermissionRsp.MasterDataRoleId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int masterDataRoleId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataRolePermissionRsp.MasterDataPermissionId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int masterDataPermissionId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataRolePermissionRsp.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataRolePermissionRsp.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
