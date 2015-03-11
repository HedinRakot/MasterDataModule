using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="ExamClass"/> entity
    /// </summary>
    [DataContract]
    public class ExamClassModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="ExamClass.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamClass.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamClass.IsMofa"/> entity
        /// </summary>
        [DataMember]
        public bool isMofa{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamClass.IsFsClass"/> entity
        /// </summary>
        [DataMember]
        public bool isFsClass{ get; set; }
        /// <summary>
        ///     Model property for <see cref="ExamClass.SortOrder"/> entity
        /// </summary>
        [DataMember]
        public int sortOrder{ get; set; }

    }
}
