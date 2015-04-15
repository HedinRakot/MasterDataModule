using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Entities.Configuration;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models.Settings
{
    /// <summary>
    ///     Model for <see cref="MasterDataWcfInfo"/> entity
    /// </summary>
    [DataContract]
    public partial class MasterDataWcfInfoModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="MasterDataWcfInfo.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWcfInfo.WsdlPath"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string wsdlPath{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWcfInfo.TimeoutChecking"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int timeoutChecking{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWcfInfo.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWcfInfo.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="MasterDataWcfInfo.LogTypeInfoId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int? logTypeInfoId{ get; set; }

    }
}
