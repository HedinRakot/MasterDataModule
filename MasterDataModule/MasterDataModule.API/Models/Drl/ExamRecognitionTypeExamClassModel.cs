using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="ExamRecognitionTypeExamClass"/> entity
    /// </summary>
    [DataContract]
    public partial class ExamRecognitionTypeExamClassModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="ExamRecognitionTypeExamClass.ExamRecognitionTypeId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int examRecognitionTypeId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamRecognitionTypeExamClass.ExamClassId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int examClassId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamRecognitionTypeExamClass.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamRecognitionTypeExamClass.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
