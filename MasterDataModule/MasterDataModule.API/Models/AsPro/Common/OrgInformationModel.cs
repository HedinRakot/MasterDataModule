using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="OrgInformation"/> entity
    /// </summary>
    [DataContract]
    public partial class OrgInformationModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="OrgInformation.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgInformation.Value"/> entity
        /// </summary>
        [DataMember]
        public string value{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgInformation.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgInformation.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
