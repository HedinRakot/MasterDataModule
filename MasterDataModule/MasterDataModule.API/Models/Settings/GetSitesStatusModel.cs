using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="GetSitesStatus"/> entity
    /// </summary>
    [DataContract]
    public partial class GetSitesStatusModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="GetSitesStatus.CheckStatus"/> entity
        /// </summary>
        [DataMember]
        public int? checkStatus{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetSitesStatus.CheckDate"/> entity
        /// </summary>
        [DataMember]
        public DateTime? checkDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetSitesStatus.Message"/> entity
        /// </summary>
        [DataMember]
        public string message{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetSitesStatus.Attempt"/> entity
        /// </summary>
        [DataMember]
        public int? attempt{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetSitesStatus.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetSitesStatus.SitePath"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string sitePath{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetSitesStatus.LogTypeInfoId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int? logTypeInfoId{ get; set; }

    }
}
