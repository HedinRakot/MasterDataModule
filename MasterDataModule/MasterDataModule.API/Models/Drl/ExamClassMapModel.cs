using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="ExamClassMap"/> entity
    /// </summary>
    [DataContract]
    public partial class ExamClassMapModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="ExamClassMap.ExamClassIdOld"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int examClassIdOld{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamClassMap.ExamClassIdActual"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int examClassIdActual{ get; set; }

    }
}
