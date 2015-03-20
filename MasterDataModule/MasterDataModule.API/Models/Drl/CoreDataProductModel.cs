using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="CoreDataProduct"/> entity
    /// </summary>
    [DataContract]
    public partial class CoreDataProductModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="CoreDataProduct.InsCoreDataProductId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int insCoreDataProductId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProduct.MinAge"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public byte minAge{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProduct.MaxAge"/> entity
        /// </summary>
        [DataMember]
        public byte? maxAge{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProduct.ExamType"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int examType{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProduct.PriorTimeInMonths"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public short priorTimeInMonths{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProduct.ExpirationInMonth"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public short expirationInMonth{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProduct.RepeatTimeInDays"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public short repeatTimeInDays{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProduct.TrainingCertFlag"/> entity
        /// </summary>
        [DataMember]
        public bool trainingCertFlag{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProduct.ResultFlag"/> entity
        /// </summary>
        [DataMember]
        public bool resultFlag{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProduct.MultiplyFlag"/> entity
        /// </summary>
        [DataMember]
        public bool multiplyFlag{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProduct.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProduct.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProduct.IsMofaPrint"/> entity
        /// </summary>
        [DataMember]
        public bool isMofaPrint{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProduct.IsAdditionalProduct"/> entity
        /// </summary>
        [DataMember]
        public bool isAdditionalProduct{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProduct.IsPrepaymentRequired"/> entity
        /// </summary>
        [DataMember]
        public bool isPrepaymentRequired{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProduct.IsMandatory"/> entity
        /// </summary>
        [DataMember]
        public bool isMandatory{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProduct.FeProductNumber"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string feProductNumber{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProduct.RepeatTimeInDaysReduced"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public short repeatTimeInDaysReduced{ get; set; }

    }
}
