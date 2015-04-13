using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="MasterDataSiteInfo"/> entity
    /// </summary>
    [DataContract]
    public partial class MasterDataSiteInfoModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="MasterDataSiteInfo.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataSiteInfo.TimeoutChecking"/> entity
        /// </summary>
        [DataMember]
        public int timeoutChecking{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataSiteInfo.SitePath"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string sitePath{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataSiteInfo.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataSiteInfo.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
