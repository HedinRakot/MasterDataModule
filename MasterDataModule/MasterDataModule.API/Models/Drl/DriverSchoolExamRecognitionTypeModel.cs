using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="DriverSchoolExamRecognitionType"/> entity
    /// </summary>
    [DataContract]
    public class DriverSchoolExamRecognitionTypeModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="DriverSchoolExamRecognitionType.DriverSchoolId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int driverSchoolId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="DriverSchoolExamRecognitionType.ExamRecognitionTypeId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int examRecognitionTypeId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="DriverSchoolExamRecognitionType.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="DriverSchoolExamRecognitionType.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
