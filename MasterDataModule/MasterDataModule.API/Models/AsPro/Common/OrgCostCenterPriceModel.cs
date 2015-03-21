using MasterDataModule.API.Validation;
using MasterDataModule.Contracts.Entities;
using System;
using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace MasterDataModule.API.Models
{
    /// <summary>
    ///     Model for <see cref="OrgCostCenterPrice"/> entity
    /// </summary>
    [DataContract]
    public partial class OrgCostCenterPriceModel: BaseModel
    {

        /// <summary>
        ///     Model property for <see cref="OrgCostCenterPrice.InsCoreDataProductId"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public int insCoreDataProductId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgCostCenterPrice.SalesOffice"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public string salesOffice{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgCostCenterPrice.MinPrice"/> entity
        /// </summary>
        [DataMember]
        public decimal? minPrice{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgCostCenterPrice.MaxPrice"/> entity
        /// </summary>
        [DataMember]
        public decimal? maxPrice{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgCostCenterPrice.StandartPrice"/> entity
        /// </summary>
        [DataMember]
        public decimal? standartPrice{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgCostCenterPrice.Quantity"/> entity
        /// </summary>
        [DataMember]
        public int quantity{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgCostCenterPrice.UnitOfMeasure"/> entity
        /// </summary>
        [DataMember]
        public string unitOfMeasure{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgCostCenterPrice.SysCurrencyId"/> entity
        /// </summary>
        [DataMember]
        public int? sysCurrencyId{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgCostCenterPrice.ChangeAbilityType"/> entity
        /// </summary>
        [DataMember]
        public int? changeAbilityType{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgCostCenterPrice.FromDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime fromDate{ get; set; }
        /// <summary>
        ///     Model property for <see cref="OrgCostCenterPrice.ToDate"/> entity
        /// </summary>
        [Required]
        [DataMember]
        public DateTime toDate{ get; set; }

    }
}
