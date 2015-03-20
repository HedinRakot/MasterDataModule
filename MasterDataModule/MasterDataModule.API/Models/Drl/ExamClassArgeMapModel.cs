using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="ExamClassArgeMap"/> entity
    /// </summary>
    [DataContract]
    public partial class ExamClassArgeMapModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="ExamClassArgeMap.ExamNameArge"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string examNameArge{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamClassArgeMap.ExamClassId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int examClassId{ get; set; }

    }
}
