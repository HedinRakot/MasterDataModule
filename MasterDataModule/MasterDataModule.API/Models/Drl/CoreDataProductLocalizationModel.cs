using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="CoreDataProductLocalization"/> entity
    /// </summary>
    [DataContract]
    public class CoreDataProductLocalizationModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="CoreDataProductLocalization.CoreDataProductId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int coreDataProductId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProductLocalization.SysLanguageId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int sysLanguageId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProductLocalization.ProductName"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string productName{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProductLocalization.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProductLocalization.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProductLocalization.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
