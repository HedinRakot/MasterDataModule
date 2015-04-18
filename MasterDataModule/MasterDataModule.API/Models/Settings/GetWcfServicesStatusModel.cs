using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="GetWcfServicesStatus"/> entity
    /// </summary>
    [DataContract]
    public partial class GetWcfServicesStatusModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="GetWcfServicesStatus.CheckStatus"/> entity
        /// </summary>
        [DataMember]
        public int? checkStatus{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetWcfServicesStatus.CheckDate"/> entity
        /// </summary>
        [DataMember]
        public DateTime? checkDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetWcfServicesStatus.Message"/> entity
        /// </summary>
        [DataMember]
        public string message{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetWcfServicesStatus.Attempt"/> entity
        /// </summary>
        [DataMember]
        public int? attempt{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetWcfServicesStatus.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetWcfServicesStatus.WsdlPath"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string wsdlPath{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetWcfServicesStatus.LogTypeInfoId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int? logTypeInfoId{ get; set; }

    }
}
