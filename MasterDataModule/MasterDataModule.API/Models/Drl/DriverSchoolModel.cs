using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="DriverSchool"/> entity
    /// </summary>
    [DataContract]
    public class DriverSchoolModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="DriverSchool.DriverSchoolNumber"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string driverSchoolNumber{ get; set; }
        /// <summary>
        ///     Model property for <see cref="DriverSchool.OrdCustomerId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int ordCustomerId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="DriverSchool.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="DriverSchool.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
