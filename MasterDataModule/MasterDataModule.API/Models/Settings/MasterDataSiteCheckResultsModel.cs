using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="MasterDataSiteCheckResults"/> entity
    /// </summary>
    [DataContract]
    public partial class MasterDataSiteCheckResultsModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="MasterDataSiteCheckResults.CheckStatus"/> entity
        /// </summary>
        [DataMember]
        public int? checkStatus{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataSiteCheckResults.CheckDate"/> entity
        /// </summary>
        [DataMember]
        public DateTime? checkDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataSiteCheckResults.Message"/> entity
        /// </summary>
        [DataMember]
        public string message{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataSiteCheckResults.Attempt"/> entity
        /// </summary>
        [DataMember]
        public int? attempt{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataSiteCheckResults.MasterDataSiteInfoId"/> entity
        /// </summary>
        [DataMember]
        public int masterDataSiteInfoId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataSiteCheckResults.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataSiteCheckResults.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
