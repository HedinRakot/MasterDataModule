using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="OrdPartnerRole"/> entity
    /// </summary>
    [DataContract]
    public partial class OrdPartnerRoleModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="OrdPartnerRole.SapQualifier"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string sapQualifier{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrdPartnerRole.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrdPartnerRole.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
