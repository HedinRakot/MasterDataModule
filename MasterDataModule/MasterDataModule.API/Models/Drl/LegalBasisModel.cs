using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="LegalBasis"/> entity
    /// </summary>
    [DataContract]
    public class LegalBasisModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="LegalBasis.Name"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string name{ get; set; }
        /// <summary>
        ///     Model property for <see cref="LegalBasis.Description"/> entity
        /// </summary>
        [DataMember]
        public string description{ get; set; }
        /// <summary>
        ///     Model property for <see cref="LegalBasis.EducationCertificateRequired"/> entity
        /// </summary>
        [DataMember]
        public bool educationCertificateRequired{ get; set; }
        /// <summary>
        ///     Model property for <see cref="LegalBasis.FirstAssignation"/> entity
        /// </summary>
        [DataMember]
        public int firstAssignation{ get; set; }
        /// <summary>
        ///     Model property for <see cref="LegalBasis.MessageReason"/> entity
        /// </summary>
        [DataMember]
        public string messageReason{ get; set; }
        /// <summary>
        ///     Model property for <see cref="LegalBasis.MessageReasonStyle"/> entity
        /// </summary>
        [DataMember]
        public string messageReasonStyle{ get; set; }
        /// <summary>
        ///     Model property for <see cref="LegalBasis.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="LegalBasis.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="LegalBasis.ReplacementId"/> entity
        /// </summary>
        [DataMember]
        public int? replacementId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="LegalBasis.PrintName"/> entity
        /// </summary>
        [DataMember]
        public string printName{ get; set; }

    }
}
