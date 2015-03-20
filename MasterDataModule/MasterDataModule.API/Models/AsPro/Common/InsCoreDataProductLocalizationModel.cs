using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="InsCoreDataProductLocalization"/> entity
    /// </summary>
    [DataContract]
    public class InsCoreDataProductLocalizationModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="InsCoreDataProductLocalization.InsCoreDataProductId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int insCoreDataProductId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProductLocalization.SysLanguageId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int sysLanguageId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProductLocalization.ProductName"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string productName{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProductLocalization.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProductLocalization.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="InsCoreDataProductLocalization.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
