using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="GetJobsStatus"/> entity
    /// </summary>
    [DataContract]
    public partial class GetJobsStatusModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="GetJobsStatus.CheckStatus"/> entity
        /// </summary>
        [DataMember]
        public int? checkStatus{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetJobsStatus.CheckDate"/> entity
        /// </summary>
        [DataMember]
        public DateTime? checkDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetJobsStatus.LastRunTime"/> entity
        /// </summary>
        [DataMember]
        public DateTime? lastRunTime{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetJobsStatus.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetJobsStatus.JobName"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string jobName{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetJobsStatus.LogTypeInfoId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int? logTypeInfoId{ get; set; }

    }
}
