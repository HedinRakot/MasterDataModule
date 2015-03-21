using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="OrgAccountingArea"/> entity
    /// </summary>
    [DataContract]
    public partial class OrgAccountingAreaModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="OrgAccountingArea.AccountingArea"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string accountingArea{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgAccountingArea.MaxOrderSum"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public decimal maxOrderSum{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgAccountingArea.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgAccountingArea.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
