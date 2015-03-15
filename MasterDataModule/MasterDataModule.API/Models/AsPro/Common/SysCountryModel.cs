using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="SysCountry"/> entity
    /// </summary>
    [DataContract]
    public class SysCountryModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="SysCountry.SapId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string sapId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysCountry.Name"/> entity
        /// </summary>
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysCountry.IsEu"/> entity
        /// </summary>
        [DataMember]
        public bool? isEu{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysCountry.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysCountry.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
