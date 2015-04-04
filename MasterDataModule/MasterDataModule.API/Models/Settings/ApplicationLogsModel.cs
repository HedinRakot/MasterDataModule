using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="ApplicationLogs"/> entity
    /// </summary>
    [DataContract]
    public partial class ApplicationLogsModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="ApplicationLogs.LogType"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int logType{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ApplicationLogs.LogLevel"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int logLevel{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ApplicationLogs.Date"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime? date{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ApplicationLogs.Message"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string message{ get; set; }

    }
}
