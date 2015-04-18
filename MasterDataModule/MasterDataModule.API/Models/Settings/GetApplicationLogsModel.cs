using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="GetApplicationLogs"/> entity
    /// </summary>
    [DataContract]
    public partial class GetApplicationLogsModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="GetApplicationLogs.LogLevel"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int logLevel{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetApplicationLogs.MessageDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime? messageDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetApplicationLogs.Message"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string message{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetApplicationLogs.FileName"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string fileName{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetApplicationLogs.LogTypeInfoId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int logTypeInfoId{ get; set; }

    }
}
