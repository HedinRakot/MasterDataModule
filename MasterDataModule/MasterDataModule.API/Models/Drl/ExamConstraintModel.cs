using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="ExamConstraint"/> entity
    /// </summary>
    [DataContract]
    public class ExamConstraintModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="ExamConstraint.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamConstraint.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamConstraint.ConstraintType"/> entity
        /// </summary>
        [DataMember]
        public int constraintType{ get; set; }

    }
}
