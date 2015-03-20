using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="DriverSchoolInfo"/> entity
    /// </summary>
    [DataContract]
    public partial class DriverSchoolInfoModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="DriverSchoolInfo.SchoolInfoId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int schoolInfoId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="DriverSchoolInfo.DriverSchoolId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int driverSchoolId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="DriverSchoolInfo.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="DriverSchoolInfo.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
