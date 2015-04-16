using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="MasterDataWindowsServiceInfo"/> entity
    /// </summary>
    [DataContract]
    public partial class MasterDataWindowsServiceInfoModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="MasterDataWindowsServiceInfo.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWindowsServiceInfo.MachineName"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string machineName{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWindowsServiceInfo.ServiceName"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string serviceName{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWindowsServiceInfo.TimeoutChecking"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int timeoutChecking{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWindowsServiceInfo.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWindowsServiceInfo.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWindowsServiceInfo.LogTypeInfoId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int? logTypeInfoId{ get; set; }

    }
}
