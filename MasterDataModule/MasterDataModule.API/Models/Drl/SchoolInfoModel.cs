using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="SchoolInfo"/> entity
    /// </summary>
    [DataContract]
    public partial class SchoolInfoModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="SchoolInfo.Description"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SchoolInfo.Text"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string text{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SchoolInfo.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="SchoolInfo.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
