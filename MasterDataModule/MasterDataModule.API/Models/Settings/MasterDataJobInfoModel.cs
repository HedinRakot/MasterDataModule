using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="MasterDataJobInfo"/> entity
    /// </summary>
    [DataContract]
    public partial class MasterDataJobInfoModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="MasterDataJobInfo.ConnectionString"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string connectionString{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataJobInfo.TableName"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string tableName{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataJobInfo.TimeoutChecking"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int timeoutChecking{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataJobInfo.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataJobInfo.JobName"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string jobName{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataJobInfo.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataJobInfo.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
