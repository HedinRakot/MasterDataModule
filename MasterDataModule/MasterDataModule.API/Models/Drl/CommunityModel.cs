using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="Community"/> entity
    /// </summary>
    [DataContract]
    public partial class CommunityModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="Community.DriverSchoolId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int driverSchoolId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="Community.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="Community.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
