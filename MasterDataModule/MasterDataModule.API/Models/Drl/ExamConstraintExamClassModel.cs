using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="ExamConstraintExamClass"/> entity
    /// </summary>
    [DataContract]
    public partial class ExamConstraintExamClassModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="ExamConstraintExamClass.ExamConstraintId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int examConstraintId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamConstraintExamClass.ExamClassId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int examClassId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamConstraintExamClass.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamConstraintExamClass.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
