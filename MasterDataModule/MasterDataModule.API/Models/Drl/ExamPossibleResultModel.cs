using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="ExamPossibleResult"/> entity
    /// </summary>
    [DataContract]
    public class ExamPossibleResultModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="ExamPossibleResult.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamPossibleResult.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamPossibleResult.IsFeePayable"/> entity
        /// </summary>
        [DataMember]
        public bool isFeePayable{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamPossibleResult.ExamCounterFlag"/> entity
        /// </summary>
        [DataMember]
        public bool examCounterFlag{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamPossibleResult.NextExamProductFlag"/> entity
        /// </summary>
        [DataMember]
        public bool nextExamProductFlag{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamPossibleResult.DriverLicenceFlag"/> entity
        /// </summary>
        [DataMember]
        public bool driverLicenceFlag{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamPossibleResult.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamPossibleResult.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamPossibleResult.IsMedicalAttestRequired"/> entity
        /// </summary>
        [DataMember]
        public bool isMedicalAttestRequired{ get; set; }

    }
}
