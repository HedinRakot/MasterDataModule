using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="SysPostCode"/> entity
    /// </summary>
    [DataContract]
    public partial class SysPostCodeModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="SysPostCode.PostCode"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string postCode{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysPostCode.City"/> entity
        /// </summary>
        [DataMember]
        public string city{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysPostCode.Street"/> entity
        /// </summary>
        [DataMember]
        public string street{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysPostCode.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SysPostCode.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
