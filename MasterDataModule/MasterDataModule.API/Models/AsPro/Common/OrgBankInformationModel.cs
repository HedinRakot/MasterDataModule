using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="OrgBankInformation"/> entity
    /// </summary>
    [DataContract]
    public class OrgBankInformationModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="OrgBankInformation.BankName"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string bankName{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgBankInformation.BankCode"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string bankCode{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgBankInformation.BankAccount"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string bankAccount{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgBankInformation.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgBankInformation.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
