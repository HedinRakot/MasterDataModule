using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="GetWinServicesStatus"/> entity
    /// </summary>
    [DataContract]
    public partial class GetWinServicesStatusModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="GetWinServicesStatus.CheckStatus"/> entity
        /// </summary>
        [DataMember]
        public int? checkStatus{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetWinServicesStatus.CheckDate"/> entity
        /// </summary>
        [DataMember]
        public DateTime? checkDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetWinServicesStatus.Message"/> entity
        /// </summary>
        [DataMember]
        public string message{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetWinServicesStatus.Attempt"/> entity
        /// </summary>
        [DataMember]
        public int? attempt{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetWinServicesStatus.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetWinServicesStatus.MachineName"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string machineName{ get; set; }
        /// <summary>
        ///     Model property for <see cref="GetWinServicesStatus.LogTypeInfoId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int? logTypeInfoId{ get; set; }

    }
}
