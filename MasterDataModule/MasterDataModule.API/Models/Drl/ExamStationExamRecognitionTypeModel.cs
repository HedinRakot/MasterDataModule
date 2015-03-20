using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="ExamStationExamRecognitionType"/> entity
    /// </summary>
    [DataContract]
    public partial class ExamStationExamRecognitionTypeModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="ExamStationExamRecognitionType.ExamStationId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int examStationId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamStationExamRecognitionType.ExamRecognitionTypeId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int examRecognitionTypeId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamStationExamRecognitionType.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamStationExamRecognitionType.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
