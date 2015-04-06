using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="MasterDataJobCheckResults"/> entity
    /// </summary>
    [DataContract]
    public partial class MasterDataJobCheckResultsModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="MasterDataJobCheckResults.LastRunTime"/> entity
        /// </summary>
        [DataMember]
        public DateTime? lastRunTime{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataJobCheckResults.CheckDate"/> entity
        /// </summary>
        [DataMember]
        public DateTime? checkDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataJobCheckResults.CheckStatus"/> entity
        /// </summary>
        [DataMember]
        public int? checkStatus{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataJobCheckResults.MasterDataJobInfoId"/> entity
        /// </summary>
        [DataMember]
        public int masterDataJobInfoId{ get; set; }

    }
}
