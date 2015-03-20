using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="ExamClassRestrictedClass"/> entity
    /// </summary>
    [DataContract]
    public partial class ExamClassRestrictedClassModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="ExamClassRestrictedClass.ExamClassId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int examClassId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamClassRestrictedClass.ExamClassIdRestricted"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int examClassIdRestricted{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamClassRestrictedClass.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamClassRestrictedClass.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
