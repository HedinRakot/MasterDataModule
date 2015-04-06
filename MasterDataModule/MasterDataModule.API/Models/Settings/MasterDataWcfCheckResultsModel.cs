using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="MasterDataWcfCheckResults"/> entity
    /// </summary>
    [DataContract]
    public partial class MasterDataWcfCheckResultsModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="MasterDataWcfCheckResults.CheckStatus"/> entity
        /// </summary>
        [DataMember]
        public int? checkStatus{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWcfCheckResults.CheckDate"/> entity
        /// </summary>
        [DataMember]
        public DateTime? checkDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWcfCheckResults.Message"/> entity
        /// </summary>
        [DataMember]
        public string message{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWcfCheckResults.Attempt"/> entity
        /// </summary>
        [DataMember]
        public int? attempt{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWcfCheckResults.MasterDataWcfInfoId"/> entity
        /// </summary>
        [DataMember]
        public int masterDataWcfInfoId{ get; set; }

    }
}
