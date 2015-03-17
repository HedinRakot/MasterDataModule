using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="ExamClassRequiredClass"/> entity
    /// </summary>
    [DataContract]
    public class ExamClassRequiredClassModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="ExamClassRequiredClass.ExamClassId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int examClassId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamClassRequiredClass.ExamClassIdRequired"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int examClassIdRequired{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamClassRequiredClass.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamClassRequiredClass.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
