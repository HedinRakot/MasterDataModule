using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="SysLanguage"/> entity
    /// </summary>
    [DataContract]
    public partial class SysLanguageModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="SysLanguage.SapId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string sapId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysLanguage.SapIdIso"/> entity
        /// </summary>
        [DataMember]
        public string sapIdIso{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysLanguage.ResourceFileName"/> entity
        /// </summary>
        [DataMember]
        public string resourceFileName{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysLanguage.IsAvailable"/> entity
        /// </summary>
        [DataMember]
        public bool isAvailable{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysLanguage.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysLanguage.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
