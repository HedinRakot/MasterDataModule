using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="ExamClassInclusiveClass"/> entity
    /// </summary>
    [DataContract]
    public partial class ExamClassInclusiveClassModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="ExamClassInclusiveClass.ExamClassId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int examClassId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamClassInclusiveClass.ExamClassIdInclusive"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int examClassIdInclusive{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamClassInclusiveClass.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamClassInclusiveClass.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamClassInclusiveClass.IsConditional"/> entity
        /// </summary>
        [DataMember]
        public bool isConditional{ get; set; }

    }
}
