using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="Authority"/> entity
    /// </summary>
    [DataContract]
    public partial class AuthorityModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="Authority.AuthorityNumber"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string authorityNumber{ get; set; }
        /// <summary>
        ///     Model property for <see cref="Authority.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="Authority.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="Authority.IsCertificateRequired"/> entity
        /// </summary>
        [DataMember]
        public bool isCertificateRequired{ get; set; }
        /// <summary>
        ///     Model property for <see cref="Authority.ReturnType"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int returnType{ get; set; }
        /// <summary>
        ///     Model property for <see cref="Authority.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="Authority.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="Authority.Name2"/> entity
        /// </summary>
        [DataMember]
        public string name2{ get; set; }
        /// <summary>
        ///     Model property for <see cref="Authority.StreetHouseNumber"/> entity
        /// </summary>
        [DataMember]
        public string streetHouseNumber{ get; set; }
        /// <summary>
        ///     Model property for <see cref="Authority.ZipCode"/> entity
        /// </summary>
        [DataMember]
        public string zipCode{ get; set; }
        /// <summary>
        ///     Model property for <see cref="Authority.City"/> entity
        /// </summary>
        [DataMember]
        public string city{ get; set; }
        /// <summary>
        ///     Model property for <see cref="Authority.SysCountryId"/> entity
        /// </summary>
        [DataMember]
        public int? sysCountryId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="Authority.Phone1"/> entity
        /// </summary>
        [DataMember]
        public string phone1{ get; set; }
        /// <summary>
        ///     Model property for <see cref="Authority.Phone2"/> entity
        /// </summary>
        [DataMember]
        public string phone2{ get; set; }
        /// <summary>
        ///     Model property for <see cref="Authority.Fax"/> entity
        /// </summary>
        [DataMember]
        public string fax{ get; set; }

    }
}
