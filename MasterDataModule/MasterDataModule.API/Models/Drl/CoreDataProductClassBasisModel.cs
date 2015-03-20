using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="CoreDataProductClassBasis"/> entity
    /// </summary>
    [DataContract]
    public partial class CoreDataProductClassBasisModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="CoreDataProductClassBasis.ExamClassId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int examClassId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProductClassBasis.CoreDataProductId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int coreDataProductId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProductClassBasis.LegalBasisId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int legalBasisId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProductClassBasis.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProductClassBasis.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="CoreDataProductClassBasis.SortOrder"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int sortOrder{ get; set; }

    }
}
